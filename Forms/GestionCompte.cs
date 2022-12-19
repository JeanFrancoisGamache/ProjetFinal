using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetFinal.Classes;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace ProjetFinal.Forms
{
    public partial class GestionCompte : Form, ICalculPrix
    {
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-GFQ1SUE\\SQLEXPRESS02;Initial Catalog=HotelLune;Integrated Security=True");

        public GestionCompte()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoirMdp_Click(object sender, EventArgs e)
        {
            //montrer le mot de passe
            if (txtMdpConnection.UseSystemPasswordChar == true)
            {
                txtMdpConnection.UseSystemPasswordChar = false;
            }

            else
            {
                txtMdpConnection.UseSystemPasswordChar = true;
            }
        }

        private void GestionCompte_Load(object sender, EventArgs e)
        {
            //Afficher l'affichage des statistique si le client est VIP
            if (VerificationConnection.VIP == true )
            {
                cnx.Open();
                grpBoxStats.Show();
                //Calculer la moyenne du nombre de jour rester à l'hôtel
                SqlCommand moyenne = new SqlCommand("SELECT AVG(DATEDIFF(d, dateDebut, dateRetour)) FROM ClientChambre", cnx);
                SqlDataReader reader = moyenne.ExecuteReader();

                while (reader.Read())
                {
                    lblStatistiques.Text = "La moyenne du nombre de journée qu'une chambre est réserver est: " + reader[0].ToString() + " jours.";
                }
                cnx.Close();
            }

            //Si le client n'est pas VIP, ne pas afficher les statistiques
            else
            {
                grpBoxStats.Hide();
            }


            cnx.Open();
            //Mettre la valeur du nom d'utilisateur
            txtNomConnection.Text = VerificationConnection.Utilisateur;

            //Mettre la valeur du mot de passe (en cherchant dans la base de donné)
            SqlCommand verifConnection = new SqlCommand("Select motDePasse from Client where (nomUtilisateur='"
                + VerificationConnection.Utilisateur + "')", cnx);
            SqlDataReader motDePasse = verifConnection.ExecuteReader();

            while (motDePasse.Read())
            {
                txtMdpConnection.Text = motDePasse[0].ToString();
            }
            
            cnx.Close();


            //Calculer le solde et Afficher le solde
            //Solde des activités
            cnx.Open();
            int SoldeActivite = 0;

            SqlCommand cmdSoldeActivite = new SqlCommand("select sum(prix) from ClientActivites where (nomUtilisateur='" + VerificationConnection.Utilisateur + "')", cnx);
            SqlDataReader AfficherSoldeAct = cmdSoldeActivite.ExecuteReader();
            while (AfficherSoldeAct.Read())
            {
                //S'il y a pas de donné, prix = 0
                try
                {
                    SoldeActivite = AfficherSoldeAct.GetInt32(0);

                }
                catch
                {
                    SoldeActivite = 0; 
                }

            }

            cnx.Close();

            //Solde des chambres
            cnx.Open();

            SqlCommand Solde = new SqlCommand("select sum(prix) from ClientChambre where (nomUtilisateur='" + VerificationConnection.Utilisateur + "')", cnx);
            SqlDataReader AfficherSolde = Solde.ExecuteReader();
            while (AfficherSolde.Read())
            {
                //Si il est VIP rajouté les frais de 100$
                if (VerificationConnection.VIP == true)
                {
                    try
                    {
                        txtSolde.Text = (Int32.Parse(AfficherSolde[0].ToString()) + 100 + SoldeActivite).ToString() ; //Ajouter 100$ et afficher
                    }
                    //Si il y a aucune réservation afficher 100$¸ puisqu'il est VIP
                    catch
                    {
                        txtSolde.Text = (100 + SoldeActivite).ToString();
                    }
                }
                //Si il n'est pas VIP ne pas ajouté 100$
                else
                {
                    try
                    {
                        txtSolde.Text = (Int32.Parse(AfficherSolde[0].ToString()) + SoldeActivite).ToString();
                    }
                    //Si il a aucune réservation
                    catch
                    {
                        txtSolde.Text = (0 + SoldeActivite).ToString();
                    }
                }
            }
            cnx.Close();
        }

        private void btnModifierMdp_Click(object sender, EventArgs e)
        {
            //Initialisé le Regex du mot de passe 
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{5,}$"; //Regex qui demande 5 caractères, minumum 1 lettre et 1 chiffre
            Regex rgMdp = new Regex(pattern);

            if (MessageBox.Show("Êtes-vous certain de vouloir changer votre mot de passe?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
                //Vérifier que le mot de passe Match le Regex
                if (rgMdp.Match(txtMdpConnection.Text).Success == false)
                {
                    MessageBox.Show("Erreur! Votre mot de passe doit avoir au moins 5 caractères, au moins 1 lettre et 1 chiffre", "Erreur!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Changer le mot de passe
                else
                {
                    cnx.Open();
                    SqlCommand changerMdp = new SqlCommand("update Client set motDePasse='" + txtMdpConnection.Text + "' where (nomUtilisateur='" + VerificationConnection.Utilisateur + "')", cnx);

                    changerMdp.ExecuteNonQuery();

                    if(VerificationConnection.VIP == true)
                    {
                        SqlCommand changerMdpVIP = new SqlCommand("update ClientVIP set motDePasse='" + txtMdpConnection.Text + "' where (nomUtilisateur='" + VerificationConnection.Utilisateur + "')", cnx);
                        changerMdpVIP.ExecuteNonQuery();
                    }
                    
                    MessageBox.Show("Le mot de passe a été modifié", "Succès", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnx.Close();
                }
            }
        }

        private void btnSupprimerCompte_Click(object sender, EventArgs e)
        {
            //Demander de confirmer s'ils veulent supprimer leur comtpe et qu'il est connecté
            if (MessageBox.Show("Êtes-vous certain de vouloir supprimer votre compte?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cnx.Open();
                

                //Vérification de si Il a encore une réservation, ne pas supprimer compte
                try
                {
                    if (VerificationConnection.VIP == true)
                    {
                        SqlCommand SupprimerVIP = new SqlCommand("delete from ClientVIP where (nomUtilisateur='" + txtNomConnection.Text + "')", cnx);
                        SupprimerVIP.ExecuteNonQuery();
                    }
                    SqlCommand Supprimer = new SqlCommand("delete from Client where (nomUtilisateur='" + txtNomConnection.Text + "')", cnx);
                    Supprimer.ExecuteNonQuery();
                    cnx.Close();
                    
                    //Réintialiser les valeurs
                    txtMdpConnection.Text = "";
                    txtNomConnection.Text = "";
                    VerificationConnection.Utilisateur = null;
                    VerificationConnection.Connecter = false;

                    MessageBox.Show("Votre compte a été supprimer", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer votre compte si vous avez une réservation de faite", "Erreur!",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            //Envoie à la fonction d'interface Calculer prix le nombre de personne
            CalculPrix(Int32.Parse(numericNbPersonne.Value.ToString()));
        }

        public void CalculPrix(int nbPersonne)
        {
            
            int PrixParPersonne = Int32.Parse(txtSolde.Text) / nbPersonne;
            MessageBox.Show("Pour " + nbPersonne + " personnes, ça va coûter " + PrixParPersonne + " $ par personne.", "Information",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
