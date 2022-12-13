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
    public partial class GestionCompte : Form
    {
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
            if (txtMdpConnection.UseSystemPasswordChar == true)
            {
                txtMdpConnection.UseSystemPasswordChar = false;
            }

            else
            {
                txtMdpConnection.UseSystemPasswordChar = true;
            }
        }
    }
}
