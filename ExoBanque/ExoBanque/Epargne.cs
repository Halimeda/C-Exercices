using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    public class Epargne : Compte
    {
        
        private DateTime _dateDernierRetrait;


        public Epargne(string numero, Personne titu):base(numero,titu)
        {
          
        }

        public Epargne(string numero, Personne titu,double solde):base(numero,titu,solde)
        {

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


        public override void Retrait(double montant)
        {
            double oldSolde = Solde;
            base.Retrait(montant);

            if (oldSolde != Solde)
            {
                DateDernierRetrait = DateTime.Now;
            }

        }


        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }

    }
}
