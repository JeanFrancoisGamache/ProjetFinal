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
    public partial class Modifier : Form
    {
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-GFQ1SUE\\SQLEXPRESS02;Initial Catalog=HotelLune;Integrated Security=True");

        public Modifier()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            txtNumeroChambre.Text = VerificationConnection.Client.Chambre;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            //Validation de la date de réservation ( pas plus que 7 jours)
            if ((dateTimeRetour.Value - dateTimeDebut.Value).Days > 7)
            {
                MessageBox.Show("Vous ne pouvez pas réserver cette chambre pour plus que 7 jours.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Vérifier que la date de retour n'est pas avant la date de début
            else if (dateTimeDebut.Value > dateTimeRetour.Value)
            {
                MessageBox.Show("Votre date de retour est invalide.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Console.WriteLine(prix);
                cnx.Close();

                cnx.Open();
                //Ajouter l'item dans ClientChambre
                SqlCommand AjoutReservation = new SqlCommand("insert into ClientChambre(nomUtilisateur, numeroChambre, dateDebut, dateRetour, prix) values('"
                    + VerificationConnection.Client.Client + "', '" + VerificationConnection.Client.Chambre + "', '" + dateTimeDebut.Value.ToString() + "', '" +
                    dateTimeRetour.Value.ToString() + "', " + prix + ")", cnx); ;

                AjoutReservation.ExecuteNonQuery();

                //Modifier la description de la chambre pour dire qu'elle est réservé
                SqlCommand ModifChambre = new SqlCommand("update Chambre set disponibilite = 'Réservé', locataire = '" + VerificationConnection.Client.Client
                    + "' where (NumeroChambre = '" + VerificationConnection.Client.Chambre + "')", cnx);

                ModifChambre.ExecuteNonQuery();

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
