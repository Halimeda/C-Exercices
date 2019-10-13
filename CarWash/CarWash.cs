using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCarWash
{
    delegate void MyDelagate(Voiture v);

    class CarWash
    {
        //MyDelagate del;

        MyDelagate del01; 

        //public CarWash()
        //{
        //    del += Preparer;
        //    del += Laver;
        //    del += Secher;
        //    del += Finaliser;
        //}

        public CarWash()
        {
            del01 = delegate (Voiture v)
            {
                Console.WriteLine("Je prépare la voiture: {0}", v.Plaque);
                Console.WriteLine("Je lave la voiture : {0}", v.Plaque);
                Console.WriteLine("Je sèche la voiture : {0}", v.Plaque);
                Console.WriteLine("Je finalise la voiture : {0}", v.Plaque);
            };
        }

        private void Preparer(Voiture v)
        {
            Console.WriteLine("Je prépare la voiture: {0}", v.Plaque);
        }

        private void Laver(Voiture v)
        {
            Console.WriteLine("Je lave la voiture : {0}", v.Plaque);
        }

        private void Secher(Voiture v)
        {
            Console.WriteLine("Je sèche la voiture : {0}", v.Plaque);
        }

        private void Finaliser(Voiture v)
        {
            Console.WriteLine("Je finalise la voiture : {0}", v.Plaque);
        }

        public void Traiter(Voiture v)
        {
            //if (del != null)
            //{
            //    del(v);
            //}

        }
    }

}
