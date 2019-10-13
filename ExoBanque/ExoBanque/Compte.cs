using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    //public delegate void PassageEnNegatifDelegate(Compte obj);

    /* Classe abstraite qui ne servira que pour l'héritage
     On ne pourra pas faire d'objet de type Compte*/

    /* La classe implemente deux interfaces =>
     obligation d'ecrire le code de ce qui se trouve 
     dans les interfaces */
    public abstract class Compte: ICustomer,IBanker
    {

        private string _numero;
        private double _solde;
        private Personne _titulaire;

        //public event PassageEnNegatifDelegate PassageEnNegatifEvent;

        public event Action <Compte> PassageEnNegatifEvent;

        protected void eventPassageNegatif(Compte obj)
        {
            if (PassageEnNegatifEvent != null)
            {
                PassageEnNegatifEvent(obj); 
            }
        }

        /* Surcharge d'opérateur => on explique comment
         faire une addition entre un double et un compte
         Attention au sens des parametres*/
        public static double operator +(double somme, Compte compte)
        {
            return somme + ((compte.Solde < 0.0) ? 0 : compte.Solde);
        }


        //Constructeur => on peut faire des surcharges
        /*les surcharges permettent d'avoir plusieures possibilités 
         de créer un objet*/
        public Compte(string num,Personne titu)
        {
            /*this => represente l'objet courant (celui qu'on utilise)*/
            this.Numero = num;
            this.Titulaire = titu;
        }

        /*surcharge du constructeur*/
        public Compte(string numero, Personne titulaire, double solde):this(numero,titulaire)
        {
            
            this.Solde = solde;
        }


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


        /*correction bonus exercice sur les interfaces*/
        //public virtual double LigneCredit
        //{
        //    get { return 0; }
        //    set { return; }
        //}


        /// <summary>
        /// Methode qui permet de faire le retrait direct
        /// </summary>
        /// <param name="montant"> somme à retirer</param>
        public virtual void Retrait(double montant)
        {   // Vitrual => peut être redefinie dans les classes enfants
            // invocation de la surcharge => pas le même nbr de paramètres
            Retrait(montant, 0);
        }


        // Surcharge de la methode retrait pour la logique interne
        protected void Retrait(double montant, double LigneCredit)
        {   //protected => seule la classe et ses enfants peuve y acceder
            try
            {
                if (montant <= 0)
                {
                    /*lancement de l'exception*/
                    throw new ArgumentOutOfRangeException("", "Impossible de retirer cela");
                }

                if (Solde - montant < -LigneCredit)
                {
                    throw new SoldeInsuffisantException(" plus d'argent, va bosser!!");
                }

                Solde -= montant;
            }
            /*on gère l'exception en l'attrapant*/
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }


        public void Depot(double montant)
        {
            try
            {
                if (montant <= 0)
                {
                    throw new ArgumentOutOfRangeException("", "Impossible de deposer cela");
                }

                Solde += montant;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        /*membre abstrait => obligatoirement dans une classe abstraite
         Obligation de redefinir dans les classes enfants non abstraites*/
        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }
    }
}
