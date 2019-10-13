using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            #region division

            //Console.WriteLine("Entrez un chiffre : ");
            //string saisie = Console.ReadLine();
            //Console.WriteLine("Entrez un chiffre : ");
            //string saisie1 = Console.ReadLine();

            //bool check = int.TryParse(saisie, out int nb);
            //bool check1 = int.TryParse(saisie1, out int nb1);

            //if (check && check1)
            //{
            //    int divE = nb / nb1;
            //    int modulo = nb % nb1;
            //    float div = (float)nb / nb1;

            //    Console.WriteLine("La division entière = {0}, Le modulo = {1}, La division {2}", divE, modulo, div);
            //    Console.Read();
            //}

            //else
            //{
            //    Console.WriteLine("Erreur, vous n'avez pas entrez des chiffres ! ");
            //}

            //int nb = 5;
            //int nb1 = 2;

            //int divE = nb / nb1;
            //int modulo = nb % nb1;
            //float div = (double)nb / nb1;

            //Console.WriteLine("La division entière = {0}, Le modulo = {1}, La division {2}", divE, modulo, div);
            //Console.Read();

            #endregion

            #region VerificationBBAN

            //string accountNb = "001275693375";
            ////"001275693376" Numéro test faux & "001275693375" Numéro test juste

            //const int VERIFY = 97;

            //string tenFirst = accountNb.Substring(0, 10);
            //string twoLast = accountNb.Substring(10);

            //long nb1 = long.Parse(tenFirst);
            //long nb2 = long.Parse(twoLast);

            //Console.WriteLine((nb1 % VERIFY == nb2 || ((nb1 % VERIFY == 0) && nb2 == 97)) ? "OK" : "KO");

            ////if (nb1 % VERIFY == nb2 || ((nb1 % VERIFY == 0) && nb2 == 97))
            ////{
            ////    Console.WriteLine("OK");
            ////}

            ////else
            ////{
            ////    Console.WriteLine("KO");
            ////}

            //Console.WriteLine(accountNb);
            //Console.WriteLine(tenFirst);
            //Console.WriteLine(twoLast);
            //Console.ReadLine();

            #endregion

            #region BBAN => IBAN

            //string accountNb = "001275693375";

            //const int VERIFY = 97;

            //long tenFirst = long.Parse(accountNb.Substring(0, 10));
            //string twoLast = accountNb.Substring(10);

            //long nb2 = long.Parse(twoLast);

            //if (tenFirst % VERIFY == nb2 || ((tenFirst % VERIFY == 0) && nb2 == 97))
            //{
            //    twoLast += nb2;
            //    twoLast += 111400;
            //    long checkNb = long.Parse(twoLast);
            //    long codeNb = 98 - (checkNb % 97);

            //    if (codeNb == 98)
            //    {
            //        codeNb = 1;
            //    }

            //    var iban = new StringBuilder();
            //    iban.Append("BE");
            //    iban.Append(string.Format("{0:00}", codeNb));
            //    iban.Append(accountNb);
            //    Console.WriteLine(iban);
            //}

            //else
            //{
            //    Console.WriteLine("Il y a une erreur dans le numéro de compte.");
            //}

            //Console.Read();


            #endregion

            #region Fibonacci

            //int fn, fn1, result;
            //fn = 0;
            //fn1 = 1;

            //Console.Write("F0 = " + fn + ", F1= " + fn1 + ", ");

            //for (int i = 2; i < 25; i++)
            //{
            //    result = fn + fn1;
            //    fn = fn1;
            //    fn1 = result;
            //    Console.Write("F{0} = {1}", i, result);
            //    if (i < 24)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //Console.ReadLine();

            #endregion

            #region Factorielle

            //long result = 1;
            //int nb;
            //bool check;

            //do
            //{
            //    Console.WriteLine("Donner un nombre");
            //    string saisie = Console.ReadLine();

            //    check = int.TryParse(saisie, out nb);

            //} while (check == false);

            //if (nb == 0)
            //{
            //    Console.WriteLine(result);
            //}

            //for (int i = 1; i <= nb; i++)
            //{
            //    result = i * result;
            //    Console.WriteLine((i - 1) + "! = " + result);
            //}
            //Console.ReadLine();

            #endregion

            #region Multiplication

            //int result;

            //for (int i = 1; i <= 20; i++)
            //{
            //    for (int nb = 1; nb <= 5; nb++)
            //    {
            //        result = i * nb;
            //        Console.Write("{0:D2}x{1:D2}={2:D2}", nb, i, result);
            //        if(nb < 5)
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion

            #region Nb Premier

            //int div = 2;

            //int count = 1;

            //string saisie = Console.ReadLine();

            //int.TryParse(saisie, out int nb);


            //for (int i = 3; i < count; i++)
            //{

            //    if ((i % div == 0) && (i != div))
            //    {
            //        Console.WriteLine(i);
            //        div = 2;
            //        count++;
            //    }
            //    div++;
            //}

            //Console.ReadLine();

            #endregion

            #region Exo_Tableau Bonus // Flowgo

            //int SIZE = 10;

            //int[] Tab = new int[SIZE];

            //Tab[0] = 2;

            //for (int i = 1; i < Tab.Length; i++)
            //{
            //    Tab[i] = Tab[i - 1] * 2;
            //}

            //for (int i = 0; i < Tab.Length; i++)
            //{
            //    if (i != 0)
            //    {
            //        Console.Write(" | ");
            //    }
            //    Console.Write(Tab[i]);
            //}
            //Console.ReadLine();

            #endregion

            #region tab_matriciel

            //int[,] Tab = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            //for (int ligne = 0; ligne < Tab.GetLength(0); ligne++)
            //{
            //    for( int colonne = 0; colonne < Tab.GetLength(1); colonne++)
            //    {
            //        Console.Write(Tab[ligne, colonne] + " | ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();


            #endregion

            #region Player_flowgo

            //int SIZE;

            //do
            //{

            //    Console.WriteLine("Entres un nombre de joueur : ");
            //    string input = Console.ReadLine();
            //    int.TryParse(input, out SIZE);
            //} while (SIZE > 10 || SIZE < 1);

            //int[] Tab = new int[SIZE];
            //int moy = 0;

            //for(int i = 0; i < Tab.Length; i++)
            //{
            //    bool OK;

            //    do
            //    {
            //        Console.WriteLine("Entrez les scores du joueur {0} : ", (i + 1));
            //        string temp = Console.ReadLine();
            //        OK = int.TryParse(temp, out Tab[i]);
            //    } while (OK == false);
            //    moy = Tab[i] + moy;
            //}
            //Console.WriteLine("La moyenne des scores est égal à : {0} ", (moy/Tab.Length));
            //Console.ReadLine();
            #endregion

            #region Exo_Algotableau N°7

            //int[] tab = new int[10];
            //tab[0] = 1;
            //int index = 0;
            //bool restart = true;
            //bool check;
            //char character;

            //do
            //{

            //    do
            //    {
            //        Console.WriteLine("Press a key : ");
            //        string saisie = Console.ReadLine();
            //        check = char.TryParse(saisie.ToUpper(), out character);
            //    } while (!check);
            //    Console.Clear();
            //    switch (character)
            //    {
            //        case 'L':
            //            if (index == 0)
            //            {
            //                tab[index] = 0;
            //                index = tab.Length - 1;
            //                tab[index] = 1;
            //            }
            //            else
            //            {
            //                tab[index] = 0;
            //                index--;
            //                tab[index] = 1;
            //            }
            //            break;
            //        case 'R':
            //            if (index == tab.Length - 1)
            //            {
            //                tab[index] = 0;
            //                index = 0;
            //                tab[index] = 1;
            //            }
            //            else
            //            {
            //                tab[index] = 0;
            //                index++;
            //                tab[index] = 1;
            //            }
            //            break;

            //        case 'Q':
            //            restart = false;
            //            break;
            //        default :
            //            Console.WriteLine("Press \'l\' (Go to Left), \'r\' (Go to Right) or \'q\' (Quit) : ");
            //            break;

            //    }
            //    for (int i = 0; i < tab.Length; i++)
            //    {
            //        if (i != 0)
            //        {
            //            Console.Write(" | ");
            //        }
            //        Console.Write(tab[i]);
            //    }
            //    Console.WriteLine();
            //} while (restart);
            //Console.WriteLine("Quit Game");
            //Console.ReadLine();
            #endregion

            #region Exo_bubbleSort

            //int[] tab = new int[10];

            //for(int i = 0; i < tab.Length; i++)
            //{
            //    Random rand = new Random(int);

            //    tab[i] = rand.Next(tab[i]);
            //    if (i != 0)
            //    {
            //        Console.Write(" | ");
            //    }
            //    Console.Write(tab[i]);
            //    Console.Read();



            //}

            #endregion

            #region List - Dico

            List<int> myList = new List<int>();
            myList.Add(25);
            myList.Add(3);
            myList.Add(10);
            myList.Add(23);

            for(int i=0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.ReadLine();
            foreach (int element in myList)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();

            Dictionary<string, string> myDico = new Dictionary<string, string>();

            myDico.Add("A", "Hello");
            myDico.Add("b", "Salut");
            myDico.Add("c", "World");
            myDico.Add("f", "H");
            myDico.Add("#", "Shéra");

            foreach(KeyValuePair<string, string> k in myDico)
            {
                Console.Write(k.Key + " ");
                Console.WriteLine(k.Value);
            }

            Console.ReadLine();

            #endregion
        }
    }
}