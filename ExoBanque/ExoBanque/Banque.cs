using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    public class Banque
    {
        private string _nom;
        private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();



        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }


        public KeyValuePair<string, Compte>[] Comptes
        {
            get { return _comptes.ToArray(); }
        }


        //Indexeur qui permet de prendre un Compte
        // sur base du numero du compte
        public Compte this[string numero]
        {
            get
            {
                Compte c;
                _comptes.TryGetValue(numero, out c);
                return c;
            }
        }

        public void Ajouter(Compte c)
        {
            c.PassageEnNegatifEvent += PassageEnNegatifAction;
            _comptes.Add(c.Numero, c);
        }

        public void Supprimer(string numero)
        {
            this[numero].PassageEnNegatifEvent -= PassageEnNegatifAction;
            _comptes.Remove(numero);
        }


        public double AvoirDesComptes(Personne titu)
        {
            double total = 0;

            foreach (Compte c in _comptes.Values)
            {
                if (c.Titulaire == titu)
                {
                    // application de la surcharge d'operateur
                    total = total + c;
                }
            }

            return total;
        }

        public void PassageEnNegatifAction(Compte obj)
        {
            foreach(Compte c in _comptes.Values)
            {
                if(obj.Numero == c.Numero)
                {
                    Console.WriteLine($"Le compte {obj.Numero} vient de passer en négatif. Signé : {this.Nom}");
                }
            }
            
        }
    }
}
