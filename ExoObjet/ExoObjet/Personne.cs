using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObjet
{
    public class Personne
    {
        private string _nom;
        private string _prenom;
        private DateTime _dateNais;

        public Personne(string nom, string prenom, DateTime dateNais)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNais = dateNais;
        }

        public string Nom
        {
            get
            {
                return _nom;
            }
            private set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            private set
            {
                _prenom = value;
            }
        }

        public DateTime DateNais
        {
            get
            {
                return _dateNais;
            }
            private set
            {
                _dateNais = value;
            }
        }
    }
}
