using static Codewars._6kyus.UniqueInOrder;

// https://www.codewars.com/kata/54e6533c92449cc251001667

namespace Tests._6kyus;

[TestFixture]
public class UniqueInOrderTest
{
    [Test]
    [Order(1)]
    public void EmptyTest()
    {
        Assert.That(UniqueInOrderFn(""), Is.EqualTo(""));
    }

    [Test]
    [Order(2)]
    public void Test1()
    {
        Assert.That(UniqueInOrderFn("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
    }

    [Test]
    [Order(3)]
    public void Test2()
    {
        Assert.That(UniqueInOrderFn("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
    }

    [Test]
    [Order(4)]
    public void Test3()
    {
        Assert.That(UniqueInOrderFn("112332444566"), Is.EqualTo("1232456"));
    }
}
