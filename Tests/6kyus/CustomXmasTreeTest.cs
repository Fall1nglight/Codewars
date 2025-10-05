using static Codewars._6kyus.CustomXmasTree;

namespace Tests._6kyus;

// https://www.codewars.com/kata/5a405ba4e1ce0e1d7800012e

[TestFixture]
public class CustomXmasTreeTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(
            CustomChristmasTree("*@o", 3),
            Is.EqualTo("  *\n" + " @ o\n" + "* @ o\n" + "  |")
        );

        Assert.That(
            CustomChristmasTree("*@o", 6),
            Is.EqualTo(
                "     *\n"
                    + "    @ o\n"
                    + "   * @ o\n"
                    + "  * @ o *\n"
                    + " @ o * @ o\n"
                    + "* @ o * @ o\n"
                    + "     |\n"
                    + "     |"
            )
        );

        Assert.That(
            CustomChristmasTree("1234", 6),
            Is.EqualTo(
                "     1\n"
                    + "    2 3\n"
                    + "   4 1 2\n"
                    + "  3 4 1 2\n"
                    + " 3 4 1 2 3\n"
                    + "4 1 2 3 4 1\n"
                    + "     |\n"
                    + "     |"
            )
        );

        Assert.That(
            CustomChristmasTree("123456789", 3),
            Is.EqualTo("  1\n" + " 2 3\n" + "4 5 6\n" + "  |")
        );
    }
}
