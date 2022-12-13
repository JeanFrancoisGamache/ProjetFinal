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


//2163245, Jean-François Gamache

namespace ProjetFinal.Forms
{
    public partial class Connection : Form
    {

        SqlConnection cnx = new SqlConnection("Data Source=C-BLBDLH83H3D3N;Initial Catalog=HotelLune;User ID=sa;Password=sql");

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

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            cnx.Open();
            {
                //Commande qui retourne 0 si il ne trouve pas l'utilisateur et 1 si il trouve l'utilisateur
                SqlCommand verifConnection = new SqlCommand("Select count(nomUtilisateur) from Client where (nomUtilisateur='" + txtNomConnection.Text + "' and motDePasse ='" + txtMdpConnection.Text + "')", cnx);
                int Confirmation = (int)verifConnection.ExecuteScalar();

                //Si il y a personne: erreur
                if (Confirmation == 0)
                {
                    MessageBox.Show("Erreur");
                    cnx.Close();
                }

                //Si la connection est bonne: Oui
                else
                {
                    //Afficher la fonctionnalité de déconnection
                    gbxConnection.Hide();
                    gbxCreation.Hide();
                    gbxDeconenction.Show();

                    
                    MessageBox.Show("Oui");
                    cnx.Close();
                }
            }
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            // if Personne est connecté
            // {
            //      gbxDeconnection.Show();
            //      gbxConnection.Hide();
            //      gbxCreation.Hide();
            // }

            //else
            //{
            //    gbxConnection.Show();
            //    gbxCreation.Show();
           //     gbxDeconenction.Hide();
            //}
        }
    }
}
