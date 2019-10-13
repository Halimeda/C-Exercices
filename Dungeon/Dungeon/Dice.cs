using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Dice
    {
        private int _max;

        public int Min

        {
            get { return 1; }
        }

        public int Max
        {
            get { return _max; }
            private set { _max = value; }
        }

        private static Random _rdm = new Random();

        public Dice(int maximum)
        {
            Max = maximum;
        }

        public int Roll()
        {
            return _rdm.Next(Min, _max + 1);
        }

        public static int StatCalcul()
        {
            int nbD = 4;
            Dice d6 = new Dice(6);
            List<int> dices = new List<int>();
            int stat = 0;

            for(int i = 0; i < nbD; i++)
            {
                dices.Add(d6.Roll());
            }
            dices.Sort();

            for (int i = 1; i < dices.Count; i++)
            {
                stat += dices[i];
            }

            return stat;

        }

    }
}
