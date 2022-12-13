using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal.Classes
{
    abstract class ClientVIP: Client
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

        public bool Vip
        {
            get { return pvip; }
            set { pvip = value; }
        }


        //Constructeurs de la classe
        public ClientVIP(string NomUtilisateur="", string MotDePasse="", bool Vip=true)
            : base(NomUtilisateur, MotDePasse)
        {
            this.Vip = Vip;
        }

    }
}
