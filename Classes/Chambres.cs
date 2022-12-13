using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2163245, Jean-François Gamache

namespace ProjetFinal.Classes
{
    internal class Chambre
    {
        //Attributs privés
        private string pNumeroChambre;
        private int pNbLitAdulte;
        private int pNbLitEnfant;
        private bool pChambreVip;

        //Propriétés des attributs privées
        public string NumeroChambre
        {
            get { return pNumeroChambre; }
            set { pNumeroChambre = value; }
        }

        public int NbLitAdulte
        {
            get { return pNbLitAdulte; }
            set { pNbLitAdulte = value; }
        }

        public int NbLitEnfant
        {
            get { return pNbLitEnfant; }
            set { pNbLitEnfant = value; }
        }

        public bool ChambreVip
        {
            get { return pChambreVip; }
            set { pChambreVip = value; }
        }

        //Constructeurs de la classe
        public Chambre(string NumeroChambre = "0-A01", int NbLitAdulte=0, int NbLitEnfant=0, bool ChambreVip=false)
        {
            this.NumeroChambre = NumeroChambre;
            this.NbLitAdulte = NbLitAdulte;
            this.NbLitEnfant = NbLitEnfant;
            this.ChambreVip = ChambreVip;
        }


    }
}
