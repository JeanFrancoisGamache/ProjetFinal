using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2163245

namespace ProjetFinal.Classes
{
    internal class ReservationChambre
    {
        //Attributs privés
        private string pClient;
        private string pChambre;
        private DateTime pDateDebut;
        private DateTime pDateRetour;
        private float pPrix;

        //Propriétés des attributs privées
        public string Client
        {
            get { return pClient; }
            set { pClient = value; }
        }

        public string Chambre
        {
            get { return pChambre; }
            set { pChambre = value; }
        }

        public DateTime DateDebut
        {
            get { return pDateDebut; }
            set { pDateDebut = value; }
        }

        public DateTime DateRetour
        {
            get { return pDateRetour; }
            set { pDateRetour = value; }
        }

        public float Prix
        {
            get { return pPrix; }
            set { pPrix = value; }
        }


        //Constructeur
        public ReservationChambre(string Client = null, string Chambre = null, DateTime DateDebut = default(DateTime), DateTime DateRetour = default(DateTime), float Prix = 0)
        {
            this.Client = Client;
            this.Chambre = Chambre;
            this.DateDebut = DateDebut;
            this.DateRetour = DateRetour;
            this.Prix = Prix;
        }
    }
}
