using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Dragon:Monster, IGold, ILeather
    {

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
