using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    public class Personne
    {

        //Champs de la classe
        #region Fields

        private string _nom;
        private string _prenom;
        private DateTime _dateNaiss;

        #endregion

        #region Constructeur
        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            this.Prenom = prenom;
            this.Nom = nom;
            this.DateNaiss = dateNaissance;

        }

        #endregion

        //Les propriétés qui gèrent les champs en 
        //lecture (get) et en écriture (set)
        #region Properties
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


        public DateTime DateNaiss
        {
            get
            {
                return _dateNaiss;
            }

            private set
            {
                _dateNaiss = value;
            }
        } 
        #endregion
    }
}
