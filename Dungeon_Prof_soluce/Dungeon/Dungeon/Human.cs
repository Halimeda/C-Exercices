using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Human:Hero
    {

        public override int Strengh
        {
            get { return base.Strengh+1; }
        }

        public override int Stamina
        {
            get { return base.Stamina+1; }
        }

    }
}
