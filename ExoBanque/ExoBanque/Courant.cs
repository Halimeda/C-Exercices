using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    // Heritage => ici Courant hérite de compte
    // Un courant est donc un Compte
    public class Courant : Compte
    {

        private double _ligneCredit;

        /* sur le constructeur :this() sert à aller chercher un constructeur
         dans la même classe*/
        public Courant(string numero, Personne titul,double ligneCred):this(numero,titul,ligneCred,0)
        {

        }

        /* sur le constructeur :base() sert à aller chercher un constructeur
         dans la classe parent*/
        public Courant(string num, Personne titu, double ligneCred, double solde): base(num, titu, solde)
        {
            this.LigneCredit = ligneCred;
        }



        public /*override*/ double LigneCredit
        {
            get
            {
                return _ligneCredit;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new InvalidOperationException("Impossible de mettre cette valeur");
                    }

                    _ligneCredit = value;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); ;
                }
            }

        }


        // override => mot clef pour redifinir (virtual ou en abstract dans le parent)
        public override void Retrait(double montant)
        {
            double soldeAvantRetrait = Solde;
            Retrait(montant, LigneCredit);
            if(Solde < 0 && soldeAvantRetrait >= 0)
            {
                eventPassageNegatif(this);
            }
        }

        protected override double CalculInteret()
        {
            if (Solde >= 0)
            {
                return Solde * 0.03;
            }
            else
            {
                return Solde * 0.0975;
            }
        }

    }
}
