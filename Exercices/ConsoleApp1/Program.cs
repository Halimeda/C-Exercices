using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int SIZE = 10;

            int[] Tab = new int[SIZE];

            Tab[0] = 2;

            for (int i = 1; i < Tab.Length; i++)
            {
                Tab[i] = Tab[i - 1] * 2;
            }

            for (int i = 0; i < Tab.Length; i++)
            {
                if(i != 0)
                {
                    Console.Write(" | ");
                }
                Console.Write(Tab[i]);
            }
            Console.ReadLine();
        }
    }
}
