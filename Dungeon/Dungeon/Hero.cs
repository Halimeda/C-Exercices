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
            if (monster is IGold && monster is ILeather)
            {
                Console.WriteLine($"You find {monster.Gold} gold and {monster.Leather} leather on {monster.GetType().Name}");
                this.Gold += monster.Gold;
                this.Leather += monster.Leather;
                Console.WriteLine($"Your total is {this.Gold} gold and {this.Leather} leather");
            }
            else if (monster is IGold)
            {
                Console.WriteLine($"You find {monster.Gold} gold on {monster.GetType().Name}");
                this.Gold += monster.Gold;
                Console.WriteLine($"Your total is {this.Gold} gold and {this.Leather} leather");
            }
            else if (monster is ILeather)
            {
                Console.WriteLine($"You find {monster.Leather} leather on {monster.GetType().Name}");
                this.Leather += monster.Leather;
                Console.WriteLine($"Your total is {this.Gold} gold and {this.Leather} leather");
            }
        }


        public void Rest()
        {
            this.PVCalcul();
        }

    }
}
