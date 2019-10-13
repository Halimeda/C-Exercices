using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    abstract class Character
    {
        private int _stamina;

        private int _strengh;

        private int _pv;

        private int _xPos;

        private int _yPos;

        private string _letter;

        protected Dice d4;
        protected Dice d6;

        public string Letter
        {
            get { return _letter; }
            set { _letter = value; }
        }

        public int YPos
        {
            get { return _yPos; }
            set { _yPos = value; }
        }


        public int XPos
        {
            get { return _xPos; }
            set { _xPos = value; }
        }


        private int PV
        {
            get { return _pv; }
            set { _pv = value; }
        }


        public virtual int Strengh
        {
            get { return _strengh; }
            private set { _strengh = value; }
        }

        public virtual int Stamina
        {
            get { return _stamina; }
            private set { _stamina = value; }
        }

        public Character()
        {
            d4 = new Dice(4);
            d6 = new Dice(6);

            this.XPos = posX;
            this.YPos = posY;
            
            this.Stamina = Dice.StatCalcul();
            this.Strengh = Dice.StatCalcul();
            PVCalcul();
        }

        protected void PVCalcul()
        {

            this.PV = this.Stamina + Modificateur(this.Stamina);
        }

        private int Modificateur(int stat)
        {
            int modif = ((stat < 5) ? -1 : (stat < 10) ? 0 : ((stat < 15) ? 1 : 2));
            return modif;         
        }

        public void Hit(Character defense)
        {
            int damage;

            damage = this.d4.Roll() + Modificateur(this.Strengh);
            Console.WriteLine($"{this.GetType().Name} hit {defense.GetType().Name}. It does {damage} damage !");
            defense.PV -= damage;
        }


    }
}
