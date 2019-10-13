using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Orc:Monster, IGold
    {

        private int _gold;

        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }

        public Orc()
        {
            Letter = "O";
        }

        public override int Strengh
        {
            get { return base.Strengh + 1; }
        }

    }
}
