using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/550498447451fbbd7600041c

[TestFixture]
public class AreTheySameTest
{
    [Test]
    public void Test1()
    {
        int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
        int[] b = new int[]
        {
            11 * 11,
            121 * 121,
            144 * 144,
            19 * 19,
            161 * 161,
            19 * 19,
            144 * 144,
            19 * 19,
        };
        bool r = AreTheySame.comp(a, b);
        Assert.That(r, Is.True);
    }
}
