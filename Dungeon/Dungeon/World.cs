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

        public int TilesNum
        {
            get { return _tilesNum; }
            set { _tilesNum = value; }
        }

        public World()
        {
            TilesNum = 15;
            MapSetter(TilesNum);


        }

        public void posSetter()
        {
            int YPos;
            int XPos;

            Tuple<int, int> tuple;

            List<Tuple<int, int>> tupleList = new List<Tuple<int, int>>();

            do
            {
                XPos = _rdm.Next(15);
                YPos = _rdm.Next(15);



            } while ();

            tuple = (XPos, YPos);

        }

        public void createMonsters()
        {


        }

        private void death()
        {

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
