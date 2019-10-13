using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    abstract class Monster : Character
    {
        private int _gold;

        private int _leather;

        public int Leather
        {
            get { return _leather; }
            set { _leather = value; }
        }

        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }

        public Monster()
        {
            Gold = this.d6.Roll();
            Leather = this.d4.Roll();
        }

    }
}
