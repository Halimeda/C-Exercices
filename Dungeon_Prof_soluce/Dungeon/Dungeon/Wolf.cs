using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Wolf:Monster, ILeather
    {
        private int _leather;

        public int Leather
        {
            get { return _leather; }
            set { _leather = value; }
        }

        public Wolf()
        {
            Letter = "W";
        }

    }
}
