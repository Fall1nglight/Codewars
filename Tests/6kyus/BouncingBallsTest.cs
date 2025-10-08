using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/5544c7a5cb454edb3c000047

[TestFixture]
public class BouncingBallsTest
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(BouncingBalls.BouncingBall(3.0, 0.66, 1.5), Is.EqualTo(3));
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(BouncingBalls.BouncingBall(30.0, 0.66, 1.5), Is.EqualTo(15));
    }
}
