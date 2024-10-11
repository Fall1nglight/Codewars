using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Katas
{
    // https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp
    public class K02VowelCount
    {
        public static int GetVowelCount(string str)
        {
            // létrehozunk egy int t. változót, amiben a végeredményt fogjuk tárolni
            int vowelCount = 0;

            // létrehozunk egy string t. változót, amiben a megszámlálandó karaktereket tároljuk
            // a feladat leírása szerint csak az 'a e, i, o, u' karaktereket kell megszámlálni
            string vowels = "aeiou";

            // for ciklussal bejárjuk a tömböt
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    vowelCount++;
                }
            }
            // megvizsgáljuk az adott elemet, hogy szerepel-e a 'vowels' string-be
            // > ha szerepel, akkor növeljük a 'vowelCount' int-et egyel

            return vowelCount;
        }
    }
}
