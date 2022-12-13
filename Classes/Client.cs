using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2163245, Jean-François Gamache

namespace ProjetFinal.Classes
{
    public class Client
    {
        //Attributs privés
        private string pnomUtilisateur;
        private string pmotDePasse;
        private bool pvip;

        //Propriétés des attributs privées
        public string NomUtilisateur
        {
            get { return pnomUtilisateur; }
            set { pnomUtilisateur = value; }
        }

        public string MotDePasse
        {
            get { return pmotDePasse; }
            set { pmotDePasse = value; }
        }


        //Constructeurs de la classe
        public Client(string NomUtilisateur = "", string MotDePasse = "")
        {
            this.NomUtilisateur = NomUtilisateur;
            this.MotDePasse = MotDePasse;
        }
    }
}
