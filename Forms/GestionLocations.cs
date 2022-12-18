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
using ProjetFinal.Classes;
using System.Configuration;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SortOrder = System.Windows.Forms.SortOrder;
//2163245 JeanFrancois Gamache

namespace ProjetFinal.Forms
{
    public partial class GestionLocations : Form
    {
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-GFQ1SUE\\SQLEXPRESS02;Initial Catalog=HotelLune;Integrated Security=True");

        public GestionLocations()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionLocations_Load(object sender, EventArgs e)
        {

            //Mettre toutes les chambres dans les chambres disponible
            cnx.Open();

            //Prendre chaque items de la base de donné et l'ajouter à une table de donné c#
            SqlCommand AjoutListeView = new SqlCommand("select * from Chambre", cnx);
            SqlDataAdapter AjoutDataAdapter = new SqlDataAdapter(AjoutListeView);
            DataTable dt = new DataTable();
            AjoutDataAdapter.Fill(dt); //Source: https://youtu.be/jRV5HPE6fW8

            //Pour chaque Row, ajout de l'item de notre DataTable
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem chambre = new ListViewItem(row[0].ToString());
                for (int index = 1; index < dt.Columns.Count; index++)
                {
                    chambre.SubItems.Add(row[index].ToString());
                }
                listViewChambres.Items.Add(chambre);
            }

            //Mettre toutes les chambres loués par l'utilisateur
            SqlCommand AjoutListeViewClient = new SqlCommand("select * from ClientChambre where (nomUtilisateur='" + VerificationConnection.Utilisateur + "')", cnx);
            SqlDataAdapter AjoutDataAdapterClient = new SqlDataAdapter(AjoutListeViewClient);
            DataTable dtClient = new DataTable();
            AjoutDataAdapterClient.Fill(dtClient); //Source: https://youtu.be/jRV5HPE6fW8

            //Pour chaque Row, ajout de l'item de notre DataTable
            foreach (DataRow row in dtClient.Rows)
            {              
                ListViewItem chambre = new ListViewItem(row[0].ToString());
                for (int index = 1; index < dtClient.Columns.Count; index++)
                {
                    chambre.SubItems.Add(row[index].ToString());
                }
                listViewChambreClient.Items.Add(chambre);
            }

            cnx.Close();
        }

        private void btnTrier_Click(object sender, EventArgs e)
        {

            listViewChambres.Sorting = SortOrder.Descending;

            
            listViewChambres.Sort();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            cnx.Open();

            //Vérifier qu'une chambre a été trouvé
            SqlCommand ConfirmerChambre = new SqlCommand("select count(NumeroChambre) from Chambre where (NumeroChambre like '%" + txtNumeroChambre.Text + "%')", cnx);
            int Confirmation = (int)ConfirmerChambre.ExecuteScalar();
            listViewChambres.Items.Clear();

            //Si il a trouvé un élément: 
            if (Confirmation != 0)
            {
                //Rajouter à la listeView toutes les chambres qui contient
                SqlCommand AjoutListeView = new SqlCommand("select * from Chambre where (NumeroChambre like '%" + txtNumeroChambre.Text + "%')", cnx);
                SqlDataAdapter AjoutDataAdapter = new SqlDataAdapter(AjoutListeView);            
                DataTable dt = new DataTable();
                AjoutDataAdapter.Fill(dt); //Source: https://youtu.be/jRV5HPE6fW8

                //Pour chaque Row, ajout de l'item de notre DataTable
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem chambre = new ListViewItem(row[0].ToString());
                    for (int index = 1; index < dt.Columns.Count; index++)
                    {
                        chambre.SubItems.Add(row[index].ToString());
                    }
                    listViewChambres.Items.Add(chambre);
                }
            }

            //S'il n'a pas trouvé d'élément
            else if (Confirmation == 0)
            {
                //Prendre chaque items de la base de donné et l'ajouter à une table de donné c#
                SqlCommand AjoutListeView = new SqlCommand("select * from Chambre where (NumeroChambre like '%" + txtNumeroChambre.Text + "%')", cnx);
                SqlDataAdapter AjoutDataAdapter = new SqlDataAdapter(AjoutListeView);
                DataTable dt = new DataTable();
                AjoutDataAdapter.Fill(dt); //Source: https://youtu.be/jRV5HPE6fW8

                //Pour chaque Row, ajout de l'item de notre DataTable
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem chambre = new ListViewItem(row[0].ToString());
                    for (int index = 1; index < dt.Columns.Count; index++)
                    {
                        chambre.SubItems.Add(row[index].ToString());
                    }
                    listViewChambres.Items.Add(chambre);
                }
            }
            cnx.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //Demandé à l'utilisateur s'il veut réellement supprimer cette réservation
           try
           {
                if (MessageBox.Show("Êtes-vous certain de vouloir annuler votre réservation à la sale " + listViewChambreClient.SelectedItems[0].SubItems[1].Text +"?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnx.Open();

                    //Enlever l'item dans ClienChambre
                    SqlCommand EnleverReservation = new SqlCommand("delete from ClientChambre where (nomUtilisateur = '" 
                        + listViewChambreClient.SelectedItems[0].SubItems[0].Text + "' and numeroChambre ='" + listViewChambreClient.SelectedItems[0].SubItems[1].Text
                        + "')", cnx);

                    //Commande pour Modifier Locataire dans Chambre
                    SqlCommand ModifierChambre = new SqlCommand("update Chambre set locataire = null, disponibilite = 'Disponible'" +
                        " where (locataire = '" + listViewChambreClient.SelectedItems[0].SubItems[0].Text + "' and numeroChambre ='" + listViewChambreClient.SelectedItems[0].SubItems[1].Text 
                        + "')", cnx);

                    //execute commandes
                    EnleverReservation.ExecuteNonQuery();
                    ModifierChambre.ExecuteNonQuery();
                    MessageBox.Show("Votre réservation a été annulé,", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listViewChambreClient.SelectedItems[0].Remove();
                    cnx.Close();
                }
           }
            catch
           {
                MessageBox.Show("Vous devez sélectionner une réservation", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Êtes-vous certain de vouloir modifier votre réservation à la salle " + listViewChambreClient.SelectedItems[0].SubItems[1].Text + "?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnx.Open();

                    SqlCommand prendreValeur = new SqlCommand("select * from ClientChambre where (numeroChambre = '" + listViewChambreClient.SelectedItems[0].SubItems[1].Text + "')", cnx);
                    SqlDataReader reader = prendreValeur.ExecuteReader();

                    while (reader.Read())
                    {
                        ReservationChambre modif = new ReservationChambre(); 
                        modif.Client = reader.GetString(0);
                        modif.Chambre = reader.GetString(1);
                        modif.DateDebut = reader.GetDateTime(2);
                        modif.DateRetour = reader.GetDateTime(3);

                        VerificationConnection.Client = modif;
                    }

                    //Envoyé à la page
                    Reservation modifier = new Reservation();
                    modifier.ShowDialog(this);


                    cnx.Close();
                }
            }
            catch
            {
                MessageBox.Show("Vous devez sélectionner une réservation", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            cnx.Open();
            //réintialiser la liste
            listViewChambreClient.Items.Clear();

            //Commande pour ajouter les donnés de la base de donnés
            SqlCommand AjoutListeViewClient = new SqlCommand("select * from ClientChambre where (nomUtilisateur='" + VerificationConnection.Utilisateur + "')", cnx);
            SqlDataAdapter AjoutDataAdapterClient = new SqlDataAdapter(AjoutListeViewClient);
            DataTable dtClient = new DataTable();
            AjoutDataAdapterClient.Fill(dtClient); //Source: https://youtu.be/jRV5HPE6fW8

            //Pour chaque Row, ajout de l'item de notre DataTable
            foreach (DataRow row in dtClient.Rows)
            {
                ListViewItem chambre = new ListViewItem(row[0].ToString());
                for (int index = 1; index < dtClient.Columns.Count; index++)
                {
                    chambre.SubItems.Add(row[index].ToString());
                }
                listViewChambreClient.Items.Add(chambre);
            }
            cnx.Close();
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            try
            {
                //Si la chambre est disponible, Initialisé la réservation de chambre
                if (listViewChambres.SelectedItems[0].SubItems[5].Text == "Disponible")
                {

                    //Vérification que si la chambre est pour vip donner accès
                    if ((listViewChambres.SelectedItems[0].SubItems[4].Text == "True" & VerificationConnection.VIP == true) || listViewChambres.SelectedItems[0].SubItems[4].Text == "False")
                    {
                        if (MessageBox.Show("Êtes-vous certain de vouloir réserver la chambre " + listViewChambres.SelectedItems[0].SubItems[0].Text + "?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //Attribués les donnés 
                            ReservationChambre louer = new ReservationChambre();
                            louer.Client = VerificationConnection.Utilisateur;
                            louer.Chambre = listViewChambres.SelectedItems[0].SubItems[0].Text;
                            VerificationConnection.Client = louer;


                            //Envoyé à la page Réserver
                            Modifier Reserver = new Modifier();
                            Reserver.ShowDialog(this);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cette chambre est réservé aux VIP", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Si la chambre n'est pas disponible, envoyé message d'erreur
                else
                {
                    MessageBox.Show("Cette chambre n'est pas disponible", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Si aucune item a été sélectionner
            catch
            {
                MessageBox.Show("Vous devez sélectionner une chambre", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntActualiserChambre_Click(object sender, EventArgs e)
        {
            listViewChambres.Items.Clear();
            cnx.Open();
            

            //Prendre chaque items de la base de donné et l'ajouter à une table de donné c#
            SqlCommand AjoutListeView = new SqlCommand("select * from Chambre", cnx);
            SqlDataAdapter AjoutDataAdapter = new SqlDataAdapter(AjoutListeView);
            DataTable dt = new DataTable();
            AjoutDataAdapter.Fill(dt); //Source: https://youtu.be/jRV5HPE6fW8

            //Pour chaque Row, ajout de l'item de notre DataTable
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem chambre = new ListViewItem(row[0].ToString());
                for (int index = 1; index < dt.Columns.Count; index++)
                {
                    chambre.SubItems.Add(row[index].ToString());
                }
                listViewChambres.Items.Add(chambre);
            }
            cnx.Close();
        }
    }
}
