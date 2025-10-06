using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/5613d06cee1e7da6d5000055

[TestFixture]
public class StepInPrimesTest
{
    [Test]
    public static void Test1()
    {
        Assert.That(StepInPrimes.Step(10, 700805, 700905), Is.Null);
        Assert.That(StepInPrimes.Step(4, 100, 110), Is.EqualTo(new long[] { 103, 107 }));
        Assert.That(StepInPrimes.Step(6, 100, 110), Is.EqualTo(new long[] { 101, 107 }));
        Assert.That(StepInPrimes.Step(2, 100, 110), Is.EqualTo(new long[] { 101, 103 }));
        Assert.That(StepInPrimes.Step(8, 300, 400), Is.EqualTo(new long[] { 359, 367 }));
        Assert.That(StepInPrimes.Step(10, 300, 400), Is.EqualTo(new long[] { 307, 317 }));
        Assert.That(StepInPrimes.Step(11, 30000, 100000), Is.Null);
    }
}
