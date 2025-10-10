using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/556e0fccc392c527f20000c5

[TestFixture]
public class XbonacciTest
{
    private Xbonacci variabonacci;
    private const double TOLERANCE = 1e-6;

    [SetUp]
    public void SetUp()
    {
        variabonacci = new Xbonacci();
    }

    [TearDown]
    public void TearDown()
    {
        variabonacci = null;
    }

    [Test]
    public void Tests()
    {
        Assert.That(
            variabonacci.Solve(new double[] { 0, 1 }, 10),
            Is.EqualTo(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }).Within(TOLERANCE)
        );

        Assert.That(
            variabonacci.Solve(new double[] { 1, 1 }, 10),
            Is.EqualTo(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }).Within(TOLERANCE)
        );

        Assert.That(
            variabonacci.Solve(new double[] { 0, 0, 0, 0, 1 }, 10),
            Is.EqualTo(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 }).Within(TOLERANCE)
        );

        Assert.That(
            variabonacci.Solve(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10),
            Is.EqualTo(new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 }).Within(TOLERANCE)
        );
    }
}
