using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec

[TestFixture]
public class PersistentBuggerTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(PersistentBugger.Persistence(39), Is.EqualTo(3));
        Assert.That(PersistentBugger.Persistence(4), Is.EqualTo(0));
        Assert.That(PersistentBugger.Persistence(25), Is.EqualTo(2));
        Assert.That(PersistentBugger.Persistence(999), Is.EqualTo(4));
    }
}
