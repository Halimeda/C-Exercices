using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            Dice de = new Dice(4);
            Console.WriteLine(de.Roll());
            Console.WriteLine(de);
            Console.WriteLine( Dice.StatCalcul());
            Human human = new Human();
            Console.WriteLine(human.Stamina);
            Console.WriteLine(human.Strengh);
            Dwarf dwarf = new Dwarf();
            Orc orc = new Orc();
            Monster dragon = new Dragon();
            human.Hit(orc);
            human.Hit(orc);
            human.Hit(orc);
            human.Hit(orc);
            human.Hit(orc);
            Console.WriteLine(orc.Gold);
            Console.WriteLine(dragon.Leather);
            Console.WriteLine(dragon.Gold);
            human.Loot(dragon);
            human.Loot(orc);
            Console.ReadLine();
        }
    }
}
