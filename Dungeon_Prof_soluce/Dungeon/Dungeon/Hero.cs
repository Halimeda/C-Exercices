using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    abstract class Hero:Character, IGold, ILeather
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

        public Hero()
        {
            Gold = 0;
            Leather = 0;
            Letter = "H";
        }

        public void Loot(Monster monster)
        {
            int mGold;
            int mLeather;

            
            if (monster is IGold && monster is ILeather)
            {
                mGold = ((IGold)monster).Gold;
                mLeather = ((ILeather)monster).Leather;
                Console.WriteLine($"You find {mGold} gold and {mLeather} leather on {monster.GetType().Name}");
                this.Gold += mGold;
                this.Leather += ((ILeather)monster).Leather;
                Console.WriteLine($"Your total is {this.Gold} gold and {this.Leather} leather");
            }
            else if (monster is IGold)
            {
                mGold = ((IGold)monster).Gold;
                Console.WriteLine($"You find {mGold} gold on {monster.GetType().Name}");
                this.Gold += mGold;
                Console.WriteLine($"Your total is {this.Gold} gold and {this.Leather} leather");
            }
            else if (monster is ILeather)
            {
                mLeather = ((ILeather)monster).Leather;
                Console.WriteLine($"You find {mLeather} leather on {monster.GetType().Name}");
                this.Leather += mLeather;
                Console.WriteLine($"Your total is {this.Gold} gold and {this.Leather} leather");
            }
        }


        public void Rest()
        {
            this.PVCalcul();
        }

    }
}
