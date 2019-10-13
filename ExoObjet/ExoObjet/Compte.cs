using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObjet
{
    public abstract class Compte : ICustomer, IBanker
    {
        private string _numero;
        private double _solde;
        private Personne _titulaire;
        protected abstract double CalculInteret();

        public string Numero
        {
            get
            {
                return _numero;
            }
            private set
            {
                _numero = value;
            }
        }

        public double Solde
        {
            get
            {
                return _solde;
            }
            private set
            {
                _solde = value;
            }
        }

        public Personne Titulaire
        {
            get
            {
                return _titulaire;
            }

            private set
            {
                _titulaire = value;
            }
        }

        public Compte(string numero, Personne titulaire)
        {
            this.Numero = Numero;
            this.Titulaire = Titulaire;
        }

        public Compte(double solde, string numero, Personne titulaire) : this(numero, titulaire)
        {
            this.Solde = solde;
        }

        internal void Retrait(double Montant, double LigneDeCredit)
        {
            try
            {
                if (Montant <= 0)
                {
                    throw new ArgumentOutOfRangeException("", "Montant inférieur à zéro");
                }
                if (Solde - Montant < -LigneDeCredit)
                {
                    throw new SoldeInsuffisantException("Le solde restant sur le compte est inssufisant.");
                    //Console.WriteLine("Le solde restant sur le compte est inssufisant. Il reste {0} sur le compte", Solde);
                }
                Solde -= Montant;
                Console.WriteLine("Votre nouveau solde est de {0}", Solde);
            }
            catch (ArgumentOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (SoldeInsuffisantException x)
            {
                Console.WriteLine(x.Message);
            }
            
            
        }

        public void Retrait(double Montant)
        {
            try
            {
                if (Montant <= 0)
                {
                    throw new ArgumentOutOfRangeException("", "Montant inférieur à zéro");
                }
                Solde += Montant;
                Console.WriteLine("Votre nouveau solde est de {0}", Solde);
            }
            catch (ArgumentOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }


        }

        public void Depot(double Montant)
        {
            try
            {
                if (Montant <= 0)
                {
                    throw new ArgumentOutOfRangeException("", "Montant inférieur à zéro");
                }
                Solde += Montant;
                Console.WriteLine("Votre nouveau solde est de {0}", Solde);
            }
            catch (ArgumentOutOfRangeException x)
            {
                Console.WriteLine(x.Message);
            }



        }

        public static double operator +(double amount, Compte c)
        {
            double result = 0;

            if (c.Solde >= 0)
            {
                result = amount + c.Solde;
            }
            return result;
        }

        public void AppliquerInteret()
        {
            Depot(CalculInteret());
            return;
        }

    }
}
