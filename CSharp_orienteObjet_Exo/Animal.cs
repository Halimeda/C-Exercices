using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_orienteObjet_Exo
{
    public class Animal
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual void Parler()
        {
            Console.WriteLine("Animal");
        }
    }
}
