using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Katas
{
    // https://www.codewars.com/kata/57cc981a58da9e302a000214/train/csharp
    public class K01SmallEnough
    {
        public bool SmallEnough(int[] a, int limit)
        {
            // létrehozunk egy bool t. változót, amiben a végeredményt fogjuk tárolni
            bool result = true;

            // ciklussal bejárjuk a tömböt
            for (int i = 0; i < a.Length; i++)
            {
                // megvizsgáljuk az adott elemet, hogy nagyobb-e a limitnél
                // > ha nagyobb, akkor a végredményt hamisra állítjuk és megszakítjuk a ciklust
                if (a[i] > limit)
                {
                    result = false;
                    break;
                }
            }

            // visszatérünk a végeredménnyel
            return result;
        }
    }
}
