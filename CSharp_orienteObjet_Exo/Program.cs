using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_orienteObjet_Exo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personne John = new Personne();
            //John.Prenom = "John";
            //John.Age = 25;
            //Personne Jane = new Personne();
            //Jane.Prenom = "Toto";
            //Jane.Age = 24;
            //John.SePresenter();
            //Jane.SePresenter();
            //Personne Bob = John;
            //Bob.Prenom = "Bob";
            //John.SePresenter();
            //Bob.SePresenter();

            Animal medor = new Chien();
            medor.Name = "Patton";
            Console.WriteLine(medor.Name);


            Animal ani = new Animal();
            ani.Name = "Ani";

            ani.Parler();

            if (medor is Chien)
            {
                Chien m = (Chien)medor;
                m.Parler();
            }

            Console.ReadLine();
        }
    }
}
