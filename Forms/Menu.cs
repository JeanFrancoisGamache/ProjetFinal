using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetFinal.Forms;
using ProjetFinal.Classes;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace ProjetFinal
{
    public partial class FormMenu : Form
    {
        //Commandes pour SQL
        SqlConnection cnx;
        SqlCommand command;
        SqlDataReader resultat;
        string Query;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (VerificationConnection.Connecter == true)
            {
                //Vérifier qu'il a juste une réservation pour cette activité
                try
                {
                    GestionLocations formAfficherChambre = new GestionLocations();
                    formAfficherChambre.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Vous ne pouvez pas avoir plus qu'une réservation pour cette activité.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

            else
            {
                MessageBox.Show("Vous devez être connecté pour accéder à cette page.", "Erreur!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {

            if (VerificationConnection.Connecter == true)
            {
                GestionCompte formGestionCompte = new GestionCompte();
                formGestionCompte.ShowDialog();
            }
            
            else
            {
                MessageBox.Show("Vous devez être connecté pour accéder à cette page.", "Erreur!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            Connection formConnection = new Connection();
            formConnection.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //Tester la connection à la base de donné
            //Configurer la connection avec la base de données
            String connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

            cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;



            //Instancier un objet SqlCommand qui prend en paramère la requête SQL et la connexion SQL.
            Query = "SELECT * from Client";
            command = new SqlCommand(Query, cnx);

            //ouvrir la connexion avec la base de données
            cnx.Open();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //Fermer l'app
            this.Close();
        }
    }
}
