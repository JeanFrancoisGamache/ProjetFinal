using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal.Forms
{
    public partial class GestionLocations : Form
    {
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
    }
}
