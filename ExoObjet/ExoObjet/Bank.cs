using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObjet
{
    class Bank
    {
        private string _nom;
        private Dictionary<string, Compte> _compte = new Dictionary<string, Compte>();

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public KeyValuePair<string, Compte>[] Compte
        {
            get { return _compte.ToArray();  }
        }

        public Compte this[string num]
        {
            get
            {
                Compte c;
                _compte.TryGetValue(num, out c);
                return c;
            }
        }

        public void Ajouter(Compte c)
        {
            _compte.Add(c.Numero, c);
        }

        public void Supprimer(string num)
        {
            _compte.Remove(num);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double total = 0;
            foreach(Compte c in _compte.Values)
            {
                if (c.Titulaire == titulaire)
                {
                    total += c;
                }
            }
            return total;
        }
    }
}
