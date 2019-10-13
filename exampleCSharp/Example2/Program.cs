using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex. 02");
            int chiffre = 12;
            Console.WriteLine(chiffre);

            int i = 0;

            while (i < 10)
            {

                Console.WriteLine(i);
                i++;
            }
            Console.Clear();
            //Console.Write("enter a name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello {0}, that's a {1} !", name, "beatiful name");

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //sb.Append(" ! ");
            //string message;

            //message = sb.ToString();
            //Console.WriteLine(message);

            //sb.Append(" Everyone");
            //Console.WriteLine(message);

            string a = "djh";
            int nb;
            bool vf = int.TryParse(a, out nb);

            Console.WriteLine(a);
            Console.WriteLine(vf);
            Console.WriteLine(nb);

            Console.ReadLine();
        }
    }
}
