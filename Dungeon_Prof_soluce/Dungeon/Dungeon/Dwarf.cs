using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Dwarf:Hero
    {

        public override int Stamina
        {
            get { return base.Stamina + 2; }
        }

    }
}
