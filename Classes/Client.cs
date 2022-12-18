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
        private int pSolde;

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

        public int Solde
        {
            get { return pSolde; }
            set { pSolde = value; }
        }

        //Constructeurs de la classe
        public Client(string NomUtilisateur = "", string MotDePasse = "", int Solde = 0)
        {
            this.NomUtilisateur = NomUtilisateur;
            this.MotDePasse = MotDePasse;
            this.Solde = Solde;
        }
    }
}
