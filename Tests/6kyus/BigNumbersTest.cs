using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/56121f3312baa28c8500005b

[TestFixture]
public class BigNumbersTest
{
    [Test]
    public void InitialTests()
    {
        Assert.That(BigNumbers.Biggest(new[] { 3803, 38, 380 }), Is.EqualTo("383803803"));
        Assert.That(BigNumbers.Biggest(new[] { 1, 2, 3 }), Is.EqualTo("321"));
        Assert.That(BigNumbers.Biggest(new[] { 121, 12 }), Is.EqualTo("12121"));
        Assert.That(BigNumbers.Biggest(new[] { 12, 128 }), Is.EqualTo("12812"));
        Assert.That(BigNumbers.Biggest(new[] { 5051, 50 }), Is.EqualTo("505150"));
        Assert.That(BigNumbers.Biggest(new[] { 10, 101 }), Is.EqualTo("10110"));
        Assert.That(BigNumbers.Biggest(new[] { 3, 30, 34, 5, 9 }), Is.EqualTo("9534330"));
    }
}
