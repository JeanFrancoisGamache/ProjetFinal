using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal.Classes
{
    public class ClientVIP: Client
    {
        //Attributs privés
        private string pnomUtilisateur;
        private string pmotDePasse;
        private bool pvip;

        //Propriétés des attributs privées
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
