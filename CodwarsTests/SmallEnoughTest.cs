using Codewars.Katas;

namespace CodwarsTests
{
    public class SmallEnoughTest : K01SmallEnough
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(true, SmallEnough(new int[] { 66, 101 }, 200));
            Assert.Equal(
                false,
                SmallEnough(new int[] { 78, 117, 110, 99, 104, 117, 107, 115 }, 100)
            );
            Assert.Equal(true, SmallEnough(new int[] { 101, 45, 75, 105, 99, 107 }, 107));
            Assert.Equal(true, SmallEnough(new int[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 120));
        }
    }
}
