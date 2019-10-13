using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObjet
{
    class Courant : Compte
    {
        private double _ligneDeCredit;


        public double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new InvalidOperationException("La valeur du montant du crédit doit être strictement upérieur à 0 !");
                    }
                    _ligneDeCredit = value;
                }
                catch (InvalidOperationException x)
                {
                    Console.WriteLine(x.Message);
                }

               

            }
        }

        public Courant(string numero, Personne titulaire):base(numero, titulaire) 
        {
        }

        public Courant(string numero, Personne titulaire, double LigneDeCredit, double solde) : base(solde, numero, titulaire)
        {
            this.LigneDeCredit = LigneDeCredit;
        }

        public Courant(string numero, Personne titulaire, double LigneDeCredit) : this(numero, titulaire, LigneDeCredit, 0)
        {

            this.LigneDeCredit = LigneDeCredit;
        }

        protected override double CalculInteret()
        {
            if (Solde >= 0)
            {
                return (Solde * 0.03);
            }
            else
            {
                return (Solde * 0.0975);
            }
        }
  

        public void Retrait(double Montant)
        {
            Retrait(Montant, LigneDeCredit);
        }

    }
}
