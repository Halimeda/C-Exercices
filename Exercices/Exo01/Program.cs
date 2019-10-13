using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo01
{
    class Program
    {

        public  static  void    SayHello(string name)

        {
            Console.WriteLine("Hello, my dear {0}", name);
            return;
        }

        public  static  int    StringLenghtAdd(string s1, string s2)
        {
            int result = s1.Length + s2.Length;
            return (result);
        }

        public  static void     ExampleMethodRef(ref double b)
        {
            b += 10;
        }

        public  static  string      ExMethodeOut(out int a)
        {
            a = 15;
            return ("Super");
        }

        public struct Equation
        {
            public double A, B, C;

            public bool Resoudre(out double? X1, out double? X2)
            {
                double delta;

                delta = Math.Pow(B, 2) - (4 * A * C);

                if (delta > 0)
                {
                    X1 = (-B - Math.Sqrt(delta)) / (2 * A);
                    X2 = (-B + Math.Sqrt(delta)) / (2 * A);
                }

                else if (delta == 0)
                {
                    X1 = -B / (2 * A);
                    X2 = X1;
                }

                else
                {
                    X1 = null;
                    X2 = null;
                    return (false);
                }
                return (true);

            }
        }

        public enum JourSemaine { Lundi = 1, Mardi = 2, Mercredi = 3, Jeudi = 4, Vendredi = 5, Samedi = 6, Dimanche = 7}

        

        static void Main(string[] args)
        {
            #region Ex: Parse

            //Console.Write("Entrez le premier chiffre : ");
            //String nb = Console.ReadLine();
            //Console.Write("Entrez le premier chiffre : ");
            //String nb1 = Console.ReadLine();
            //int result = int.Parse(nb) + int.Parse(nb1);

            //Console.WriteLine(result);
            //Console.Read();


            #endregion

            #region tryparse

            //Console.Write("Entrez le premier chiffre : ");
            //String nb = Console.ReadLine();
            //Console.Write("Entrez le premier chiffre : ");
            //String nb1 = Console.ReadLine();
            //int nbConvert;
            //int nb1Convert;

            //bool ok = int.TryParse(nb, out nbConvert);
            //bool ok1 = int.TryParse(nb1, out nb1Convert);

            //if(ok && ok1)
            //{
            //    int result = nbConvert + nb1Convert;
            //    Console.WriteLine(result);
            //}
            //Console.Read();

            #endregion

            #region Ex_methodes

            //Console.WriteLine(StringLenghtAdd("Hello", "World"));
            //SayHello("Shéra");
            //double number = 2.5;
            //Console.WriteLine("Before : {0}", number);
            //ExampleMethodRef(ref number);
            //Console.WriteLine("After : {0}", number);
            //string s1 = ExMethodeOut(out int nb);
            //Console.WriteLine(s1 + " " + nb);
            //Console.ReadLine();

            //Equation test;
            //test.A = 2;
            //test.B = 9;
            //test.C = -5;
            //double? X1;
            //double? X2;

            //Console.WriteLine(test.Resoudre(out X1, out X2));
            //Console.WriteLine("{0} {1}", X1, X2);
            //Console.ReadLine();

            #endregion

            #region Enum

            JourSemaine weekend = JourSemaine.Dimanche;
            Console.WriteLine(weekend);
            string j = weekend.ToString();
            j = "Mard";
            Console.WriteLine((int)weekend);

            foreach (string s in Enum.GetNames(typeof(JourSemaine)))
            {
                Console.WriteLine(s);
            }

            //JourSemaine day = (JourSemaine)Enum.Parse(typeof(JourSemaine), j);
            JourSemaine day;
            if (Enum.TryParse<JourSemaine>(j, out day))
            {
                Console.WriteLine("{0} est le {1} jour de la semaine.", day.ToString(), (int)day);
            }

            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();

            #endregion

            #region ex02


            //Console.WriteLine("Veuillez entrer un chiffre : ");
            //string str = Console.ReadLine();
            //bool ok = int.TryParse(str, out int nb);

            //if (ok)
            //{
            //    int result = (nb / 2) + (nb / 2);
            //    if (result == nb)
            //    {
            //        Console.Write("Le nombre est pair !");
            //    }
            //    else
            //    {
            //        Console.Write("Le nombre est impair !");
            //    }

            //}

            //Console.ReadLine();

            #endregion

        }
    }
}
