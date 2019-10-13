using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_orienteObjet_Exo
{
    public class Chien : Animal
    {
        private string _pedigre;

        public string Pedigre
        {
            get { return _pedigre; }
            set { _pedigre = value; }
        }

        public override void Parler()
        {
            Console.WriteLine("Chien");
        }


    }



}
