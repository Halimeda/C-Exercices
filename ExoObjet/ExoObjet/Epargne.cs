using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObjet
{
    class Epargne : Compte
    {

        private DateTime _dateDernierRetrait;

        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Epargne(double solde, string numero, Personne titulaire) : base(solde, numero, titulaire)
        {

        }

        protected override double CalculInteret()
        {
            return (Solde * 0.045);
        }


        public DateTime DateDernierRetrait
        {
            get
            {
                return _dateDernierRetrait;
            }

            private set
            {
                _dateDernierRetrait = value;
            }
        }

        public void Retrait(double Montant)
        {
            Retrait(Montant);
        }
    }
}
