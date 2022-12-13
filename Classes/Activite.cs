﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2163245, Jean-François Gamache

namespace ProjetFinal.Classes
{
    internal class Activite
    {
        //Attributs privés
        private string pSalle;
        private string pType;
        private List<string> pHeureDispo;

        //Propriétés des attributs privées
        public string Salle
        {
            get { return pSalle; }
            set { pSalle = value; }
        }

        public string Type
        {
            get { return pType; }
            set { pType = value; }
        }

        public List<string> HeureDispo
        {
            get { return pHeureDispo; }
            set { pHeureDispo = value; }
        }


        //Constructeurs de la classe
        public Activite(string Salle = "1-01", string Type = "", List<string> HeureDispo = null)
        {
            this.Salle = Salle;
            this.Type = Type;
            this.HeureDispo = HeureDispo;
        }


    }
}
