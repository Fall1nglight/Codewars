using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/528d9adf0e03778b9e00067e

[TestFixture]
public class FindTheMineTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(
                new int[,]
                {
                    { 1, 0 },
                    { 0, 0 },
                }
            ).Returns(new Tuple<int, int>(0, 0));
            yield return new TestCaseData(
                new int[,]
                {
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                }
            ).Returns(new Tuple<int, int>(0, 0));
            yield return new TestCaseData(
                new int[,]
                {
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 0 },
                }
            ).Returns(new Tuple<int, int>(2, 2));
        }
    }

    [Test, TestCaseSource("testCases")]
    public Tuple<int, int> Test(int[,] field) => FindTheMine.MineLocation(field);
}
