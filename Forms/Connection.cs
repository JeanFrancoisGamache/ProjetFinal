using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using ProjetFinal.Classes;


//2163245, Jean-François Gamache

namespace ProjetFinal.Forms
{
    public partial class Connection : Form
    {

        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-GFQ1SUE\\SQLEXPRESS02;Initial Catalog=HotelLune;Integrated Security=True");

        public Connection()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            cnx.Open();
            //Commande qui retourne 0 si il ne trouve pas l'utilisateur et 1 si il trouve l'utilisateur
            SqlCommand verifConnection = new SqlCommand("Select count(nomUtilisateur) from Client where (nomUtilisateur='" + txtNomCreer.Text + "')", cnx);
            int Confirmation = (int)verifConnection.ExecuteScalar();

            //Si le nom d'utilisateur n'est pas déjà utilisé
            if (Confirmation == 0)
            {
                //Initialisé le Regex du mot de passe 
                string pattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{5,}$"; //Regex qui demande 5 caractères, minumum 1 lettre et 1 chiffre
                Regex rgMdp = new Regex(pattern);

                //Vérifier que le nom d'utilisateur est plus que 3 caractères
                if (txtNomCreer.Text.Length < 3)
                {
                    MessageBox.Show("Erreur! Votre nom d'utilisateur doit contenir au moins 4 caractères.", "Erreur!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Si le Regex du mot de passe n'est pas respecté
                else if (rgMdp.Match(txtMdpCreer.Text).Success == false)
                {
                    MessageBox.Show("Erreur! Votre mot de passe doit avoir au moins 5 caractères, au moins 1 lettre et 1 chiffre", "Erreur!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                //Si toutes les contraintes sont respectés
                else
                {
                    
                    //Ajouter les valeurs à la base de donné SQL
                    Client client = new Client(txtNomCreer.Text, txtMdpCreer.Text);
                    SqlCommand ajout = new SqlCommand("insert into Client(nomUtilisateur, motDePasse) values(@nomUtilisateur, @MotDePasse)", cnx);
                    ajout.Parameters.AddWithValue("@nomUtilisateur", client.NomUtilisateur);
                    ajout.Parameters.AddWithValue("@MotDePasse", client.MotDePasse);
                    ajout.ExecuteNonQuery();

                    //Si le client veut être VIP
                    if (checkVIP.Checked == true)
                    {
                        ClientVIP clientVip = new ClientVIP(txtNomCreer.Text, txtMdpCreer.Text);
                        MessageBox.Show("Des frais de 100$ seront rajouté à votre compte pour l'abonemment VIP", "Information VIP",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand ajoutVIP = new SqlCommand("insert into ClientVIP(nomUtilisateur, motDePasse) values(@nomUtilisateur, @MotDePasse)", cnx);
                        ajoutVIP.Parameters.AddWithValue("@nomUtilisateur", clientVip.NomUtilisateur);
                        ajoutVIP.Parameters.AddWithValue("@MotDePasse", clientVip.MotDePasse);
                        ajoutVIP.ExecuteNonQuery();
                    }

                    //Message de réussite et réinitialisé les valeurs
                    MessageBox.Show("Le Compte a été créé", "Succès!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                    txtMdpCreer.Text = "";
                    txtNomCreer.Text = "";
                }
            }
            //Si le nom d'utilisateur est déjà utilisé
            else
            {
                MessageBox.Show("Erreur! Ce nom d'utilisateur existe déjà!", "Erreur!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnx.Close();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            cnx.Open();
            {
                //Commande qui retourne 0 si il ne trouve pas l'utilisateur et 1 si il trouve l'utilisateur
                SqlCommand verifConnection = new SqlCommand("Select count(nomUtilisateur) from Client where (nomUtilisateur='" + txtNomConnection.Text + "' " +
                    "and motDePasse ='" + txtMdpConnection.Text + "')", cnx);
                int Confirmation = (int)verifConnection.ExecuteScalar();

                //Vérification VIP
                SqlCommand verifVIP = new SqlCommand("Select count(nomUtilisateur) from ClientVIP where (nomUtilisateur='" + txtNomConnection.Text + "' " +
                    "and motDePasse ='" + txtMdpConnection.Text + "')", cnx);
                int ConfirmationVIP = (int)verifVIP.ExecuteScalar();

                //Si il y a personne: erreur
                if (Confirmation == 0)
                {
                    MessageBox.Show("Erreur! Votre mot de passe ou votre nom d'utilisateur est mauvais.", "Erreur!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Si la connection est bonne: Oui
                else
                {
                    //Si le client n'est pas VIP
                    if (ConfirmationVIP == 0)
                    {
                        //Afficher la fonctionnalité de déconnection
                        gbxConnection.Hide();
                        gbxCreation.Hide();
                        gbxDeconenction.Show();
                        VerificationConnection.Connecter = true;
                        VerificationConnection.Utilisateur = txtNomConnection.Text;
                        VerificationConnection.VIP = false;

                        txtNomConnection.Text = "";
                        txtMdpConnection.Text = "";
                    }
                    //Si le client est VIP
                    else
                    {
                        //Afficher la fonctionnalité de déconnection
                        gbxConnection.Hide();
                        gbxCreation.Hide();
                        gbxDeconenction.Show();
                        VerificationConnection.Connecter = true;
                        VerificationConnection.Utilisateur = txtNomConnection.Text;
                        VerificationConnection.VIP = true;

                        txtNomConnection.Text = "";
                        txtMdpConnection.Text = "";
                    }
                }
                cnx.Close();
            }
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            //Vérifier si quelqu'un est connecté à l'application pour afficher les options disponibles.
            if (VerificationConnection.Connecter == true)
            {
                  gbxDeconenction.Show();
                  gbxConnection.Hide();
                  gbxCreation.Hide();
            }

            else
            {
                gbxConnection.Show();
                gbxCreation.Show();
                gbxDeconenction.Hide();
            }
        }

        private void btnDeconnection_Click(object sender, EventArgs e)
        {
            //Réinitialisé la classe statique pour dire qu'aucune personne est connecté
            VerificationConnection.Connecter = false;
            //Montrer les éléments de connection
            gbxConnection.Show();
            gbxCreation.Show();
            gbxDeconenction.Hide();
        }
    }
}
