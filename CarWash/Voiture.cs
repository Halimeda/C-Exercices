using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCarWash
{
    class Voiture
    {
        private string _plaque;

        public string Plaque
        {
            get { return _plaque; }
            private set { _plaque = value; }
        }

        public Voiture(string numero)
        {
            Plaque = numero;
        }

    }
}
