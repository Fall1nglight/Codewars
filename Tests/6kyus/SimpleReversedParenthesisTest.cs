using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/5a3f2925b6cfd78fb0000040

[TestFixture]
public class SimpleReversedParenthesisTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(SimpleRevesedParenthesis.solve("())()))))()()("), Is.EqualTo(4));
        Assert.That(SimpleRevesedParenthesis.solve("(((())"), Is.EqualTo(1));
        Assert.That(SimpleRevesedParenthesis.solve(")()("), Is.EqualTo(2));
        Assert.That(SimpleRevesedParenthesis.solve("((()"), Is.EqualTo(1));
        Assert.That(SimpleRevesedParenthesis.solve("((("), Is.EqualTo(-1));
        Assert.That(SimpleRevesedParenthesis.solve("())((("), Is.EqualTo(3));
    }
}
