using ProjetFinal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal.Forms
{

    public partial class Reservation : Form
    {
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-GFQ1SUE\\SQLEXPRESS02;Initial Catalog=HotelLune;Integrated Security=True");

        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            txtNumeroChambre.Text = VerificationConnection.Client.Chambre;
            dateTimeDebut.Value = VerificationConnection.Client.DateDebut;
            dateTimeRetour.Value = VerificationConnection.Client.DateRetour;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

            //Validation de la date de réservation
            if((dateTimeRetour.Value - dateTimeDebut.Value).Days > 7)
            {
                MessageBox.Show("Vous ne pouvez pas réserver cette chambre pour plus que 7 jours.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Si la validation est correcte, modifier la réservation
            else
            {
                cnx.Open();


                //Calculer le prix
                int prix = 0;
                SqlCommand TrouverPrixParJour = new SqlCommand("select PrixParJour from Chambre where (numeroChambre = '" + VerificationConnection.Client.Chambre + "')", cnx);
                SqlDataReader reader = TrouverPrixParJour.ExecuteReader();
            
                while (reader.Read()) 
                {
                    prix = Int32.Parse(reader[0].ToString()) * (dateTimeRetour.Value - dateTimeDebut.Value).Days;
                }
                cnx.Close();

                cnx.Open();
                //Enlever l'item dans ClientChambre
                SqlCommand EnleverReservation = new SqlCommand("update ClientChambre set dateDebut='" + dateTimeDebut.Value.ToString() 
                    + "', dateRetour='" + dateTimeRetour.Value.ToString() + "', prix = " + prix + " where (nomUtilisateur = '" 
                    + VerificationConnection.Client.Client + "' and numeroChambre ='" + VerificationConnection.Client.Chambre+ "')", cnx);

                EnleverReservation.ExecuteNonQuery();
            
                cnx.Close();
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
