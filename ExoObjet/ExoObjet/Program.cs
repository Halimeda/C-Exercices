using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1995, 01, 15);
            Personne Shera = new Personne("Stark", "Shéra", date);

            
            Console.WriteLine(Shera.DateNais);

            Courant C001 = new Courant("C001", Shera);
            Courant C002 = new Courant("C002", Shera);
            IBanker banker = C002;
            ICustomer customer = C002;

            customer.Depot(1500);


            C001.LigneDeCredit = 1000;

            C001.Depot(2600.51);
            C001.Retrait(250);
            Console.WriteLine(C001.Solde);

            C002.LigneDeCredit = 200;
            C002.Depot(10);
            Console.WriteLine(C002.Solde);

            Bank MyBank = new Bank();
            MyBank.Nom = "Banque";
            MyBank.Ajouter(C001);
            MyBank.Ajouter(C002);



            banker.AppliquerInteret();
            customer.Depot(50);

            Console.WriteLine(MyBank["C001"].Solde);
            Console.WriteLine(MyBank["C002"].Solde);
            Console.WriteLine(MyBank.AvoirDesComptes(Shera));
            Console.ReadLine();

            foreach (KeyValuePair<string, Compte> element in MyBank.Compte)
            {
                Console.WriteLine("Avant interet:");
                Console.WriteLine($"Compte n° {element.Key} solde: {element.Value.Solde}");
                element.Value.AppliquerInteret();
                Console.WriteLine("Après interet:");
                Console.WriteLine($"Compte n° {element.Key} solde: {element.Value.Solde}");
            }
            Console.ReadLine();

        }
    }
}
