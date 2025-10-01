namespace Tests._8kyus;

using static Codewars._8kyus.SquareNSum;

// https://www.codewars.com/kata/515e271a311df0350d00000f

[TestFixture]
public class SquareNSumTest
{
    private static IEnumerable<TestCaseData> sampleTestCases
    {
        get
        {
            yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(9);
            yield return new TestCaseData(new int[] { 1, 2 }).Returns(5);
            yield return new TestCaseData(new int[] { 5, 3, 4 }).Returns(50);
            yield return new TestCaseData(new int[] { }).Returns(0);
        }
    }

    [Test, TestCaseSource("sampleTestCases"), Description("Sample Tests")]
    public int SampleTest(int[] n) => SquareSum(n);
}
