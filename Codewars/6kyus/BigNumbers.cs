namespace Codewars._6kyus;

// https://www.codewars.com/kata/56121f3312baa28c8500005b

public class BigNumbers
{
    public static string Biggest(int[] nums)
    {
        // 1. definiálunk egy string típusú változót, amiben majd az összefűzött számot fogjuk tárolni és kezdő értéke a tömb első eleme
        // 2. számláló ciklussal bejárjuk a tömböt a második elemtől kezdve
        //  a ciklusváltozó indexén lévő elemet beillesztjük az eddigi összeállított szám elé, és mögé
        //  majd számmá alakítjuk őket és eldöntjük melyik a nagyobb
        // 3. a nagyobb értékűt visszaalakítjuk string típúsúvá és felülírjuk vele az eddigi összeállított számot
        // 4. a ciklus után visszaadjuk az összeállított számot

        // note: ezzel az a baj, hogy csak az egymás után lévő elemek eseteit nézi meg

        // string result = nums[0].ToString();
        //
        // for (int i = 1; i < nums.Length; i++)
        // {
        //     long preNum = long.Parse(string.Concat(nums[i].ToString(), result));
        //     long postNum = long.Parse(string.Concat(result, nums[i].ToString()));
        //
        //     result = Math.Max(preNum, postNum).ToString();
        // }
        //
        // return result;

        // helyes megoldás, rendezés használata, amely az összes elemet nézi
        var numbers = nums.Select(x => x.ToString()).ToArray();

        if (numbers.All(x => x == "0"))
            return "0";

        // bejárjuk a teljes tömböt
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            // bejárjuk a tömb még NEM rendezett részét
            for (int j = i + 1; j < numbers.Length; j++)
            {
                string a = numbers[i];
                string b = numbers[j];

                // ha (b+a) nagyobb mint (a+b), akkor a "b" elemet "a" elé helyezi
                if (string.Compare(b + a, a + b, StringComparison.Ordinal) > 0)
                {
                    numbers[i] = b;
                    numbers[j] = a;
                }
            }
        }

        return string.Concat(numbers);
    }
}
