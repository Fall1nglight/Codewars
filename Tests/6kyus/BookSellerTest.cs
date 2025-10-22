using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/54dc6f5a224c26032800005c

[TestFixture]
public class BookSellerTest
{
    [Test]
    public void Test1()
    {
        string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
        String[] cd = new String[] { "A", "B" };
        Assert.That(BookSeller.StockSummary(art, cd), Is.EqualTo("(A : 200) - (B : 1140)"));
    }
}
