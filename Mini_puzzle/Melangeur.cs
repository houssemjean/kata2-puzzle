using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Mini_puzzle
{
    public class Melangeur : IComparer
    {
        private static Random rnd;
        static Melangeur()
        {
            rnd = new  Random();
        }

        public int Compare(object x, object y)
        {
            if (x.Equals(y))
                return 0;
            else
            {
                return Melangeur.rnd.Next(-1, 1);
            }
        }
    }

}
