using static Codewars._6kyus.ArrayDifference;

namespace Tests._6kyus;

// https://www.codewars.com/kata/523f5d21c841566fde000009

[TestFixture]
public class ArrayDifferenceTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        Assert.That(ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }), Is.EqualTo(new int[] { 2 }));
        Assert.That(
            ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }),
            Is.EqualTo(new int[] { 2, 2 })
        );
        Assert.That(ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }), Is.EqualTo(new int[] { 1 }));
        Assert.That(
            ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }),
            Is.EqualTo(new int[] { 1, 2, 2 })
        );
        Assert.That(ArrayDiff(new int[] { }, new int[] { 1, 2 }), Is.EqualTo(new int[] { }));
        Assert.That(
            ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }),
            Is.EqualTo(new int[] { 3 })
        );
    }
}
