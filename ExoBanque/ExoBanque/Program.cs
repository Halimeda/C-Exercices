using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne john = new Personne("Smith", "John", new DateTime(1962, 6, 7));
            //john.Prenom = "John";
            //john.Nom = "Smith";
            //john.DateNaiss = new DateTime(1962, 6, 7);

            Courant C1 = new Courant("C001", john, 200);
            //C1.Numero = "C001";
            //C1.Titulaire = john;
            //C1.LigneCredit = 200;

            C1.Depot(500);
            C1.Retrait(100);

            Console.WriteLine($"Le compte n° {C1.Numero} a pour titulaire {C1.Titulaire.Prenom} et a un solde de {C1.Solde}");

            Courant C2 = new Courant("C002", john,0);
            //C2.Numero = "C002";
            //C2.Titulaire = john;
            //C2.Depot(300);


            Courant C3 = new Courant("C003",john,400);
            //C3.Numero = "C003";
            //C3.Titulaire = john;
            //C3.LigneCredit = 400;
            //C3.Retrait(200);

            Banque MaBanque = new Banque();
            MaBanque.Nom = "Ma Banque";
            MaBanque.Ajouter(C1);
            MaBanque.Ajouter(C2);
            MaBanque.Ajouter(C3);


            Epargne E1 = new Epargne("E001",john);
            //E1.Numero = "E001";
            //E1.Titulaire = john;
            //E1.Depot(300);

            MaBanque.Ajouter(E1);
            //Console.WriteLine(MaBanque["C001"].Solde);

            Console.WriteLine($"l'avoirs des comptes de john est de: {MaBanque.AvoirDesComptes(john)}");




            Console.WriteLine("==== TAUX ====");

            foreach (KeyValuePair<string,Compte> item in MaBanque.Comptes)
            {
                Console.WriteLine("Avant interêts:");
                Console.WriteLine($"Compte n° {item.Key} solde: {item.Value.Solde}");
                item.Value.AppliquerInteret();
                Console.WriteLine("Après interêts:");
                Console.WriteLine($"Compte n° {item.Key} solde: {item.Value.Solde}");
                Console.WriteLine();

                
            }


            /*======= Interfaces =======*/

            //ICustomer client = C1;
            //client.Depot(20);

            //IBanker banquier = C1;
            //banquier.AppliquerInteret();


            Console.WriteLine(C1.Solde);
            //C1.Depot(-500);
            //C1.Retrait(-500);
            C1.LigneCredit = 1000;
            C1.Retrait(850);
            Console.WriteLine(C1.Solde);

            Console.ReadLine();
        }
    }
}
