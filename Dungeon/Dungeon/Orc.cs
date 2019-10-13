using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Orc:Monster, IGold
    {

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
