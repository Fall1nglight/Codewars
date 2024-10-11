using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars.Katas;

namespace CodwarsTests
{
    public class K02VowelCountTest : K02VowelCount
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(5, GetVowelCount("abracadabra"));
        }
    }
}
