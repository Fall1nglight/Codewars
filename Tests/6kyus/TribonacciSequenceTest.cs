using Codewars._6kyus;

namespace Tests._6kyus;

[TestFixture]
public class TribonacciSequenceTest
{
    private TribonacciSequence _variabonacci;

    [SetUp]
    public void SetUp()
    {
        _variabonacci = new TribonacciSequence();
    }

    [TearDown]
    public void TearDown()
    {
        _variabonacci = null!;
    }

    [Test]
    public void Tests()
    {
        Assert.That(
            _variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10),
            Is.EqualTo(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 })
        );
        Assert.That(
            _variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10),
            Is.EqualTo(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 })
        );
        Assert.That(
            _variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10),
            Is.EqualTo(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 })
        );

        Assert.That(
            _variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 1),
            Is.EqualTo(new double[] { 1 })
        );
    }
}
