using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/559536379512a64472000053

[TestFixture]
public class PassphrasesTest
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(Passphrases.playPass("I LOVE YOU!!!", 1), Is.EqualTo("!!!vPz fWpM J"));
    }

    [Test, Order(2)]
    public void Test4()
    {
        Assert.That(
            Passphrases.playPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2),
            Is.EqualTo("4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO")
        );
    }
}
