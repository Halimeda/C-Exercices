using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class World
    {
        private int _tilesNum;

        private static Random _rdm = new Random();

        private Hero _hero;

        private int _nbMonters;

        public int NbMonsters
        {
            get { return _nbMonters; }
            set { _nbMonters = value; }
        }


        public Hero Hero
        {
            get { return _hero; }
            set { _hero = value; }
        }


        public int TilesNum
        {
            get { return _tilesNum; }
            set { _tilesNum = value; }
        }

        public World()
        {
            TilesNum = 15;
            NbMonsters = 10;
            MapSetter(TilesNum);
        }

        public void CreateMonsters()
        {
            for (int i = 0; i < NbMonsters; i++)
            {
                int choice;

                choice = _rdm.Next(3);

                if (choice == 0)
                {
                    Monster orc = new Orc();
                    Console.WriteLine($"orc{i}");
                }

                else if(choice == 1)
                {
                    Monster wolf = new Wolf();
                    Console.WriteLine($"wolf{i}");

                }

                else
                {
                    Monster dragon = new Dragon();
                    Console.WriteLine($"dragon{i}");

                }
            }

        }

        public void StartGame()
        {
            string playerChoice;
            Console.WriteLine("Welcome in Sherwood ! Your Hero must fight all the monsters in the wood !");
            do
            {
                Console.WriteLine("Choose your Hero : Human (H) or Dwarf (D)");
                playerChoice = Console.ReadLine();
            } while (playerChoice != "H" && playerChoice != "D");

            if (playerChoice == "H")
            {
                Hero = new Human();
            }
            else
            {
                Hero = new Dwarf();
            }
            CreateMonsters();
        }

        private void Death(Character pj)
        {
            if (pj is Hero)
            {
                Console.WriteLine("Game Over");
            }
        }

        public void MapSetter(int nbTiles)
        {
            for (int i = 0; i < nbTiles; i++)
            {
                for (int j = 0; j < nbTiles; j++)
                {
                    Console.Write($"|{j}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
