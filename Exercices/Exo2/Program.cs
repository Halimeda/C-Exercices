using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Veuillez entrer un chiffre : ");
                string str = Console.ReadLine();
                bool ok = int.TryParse(str, out int nb);

                if (ok)
                {
                    int result = (nb / 2) + (nb / 2);
                    if (result == nb)
                    {
                        Console.Write("Le nombre est pair !");
                    }
                    else
                    {
                        Console.Write("Le nombre est impair !");
                    }

                }

                Console.ReadLine();
        }
    }
}
