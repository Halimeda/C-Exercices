using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCarWash
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture test = new Voiture("001");
            CarWash A = new CarWash();

            A.Traiter(test);
            Console.ReadLine();
        }
    }
}
