using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Dragon:Monster, IGold, ILeather
    {

        private int _leather;
        private int _gold;

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


        public Dragon()
        {
            Letter = "D";
        }

        public override int Stamina
        {
            get { return base.Stamina + 1; }
        }


    }
}
