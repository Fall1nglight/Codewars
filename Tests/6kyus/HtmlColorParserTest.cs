// using Codewars._6kyus;
//
// namespace Tests._6kyus;
//
// // https://www.codewars.com/kata/58b57ae2724e3c63df000006
//
// [TestFixture]
// public class HtmlColorParserTest
// {
//     // test cannot be used due to DI
//     private readonly HtmlColorParser parser = new HtmlColorParser(PresetColors.Map);
//
//     [Test]
//     public void ExampleTests()
//     {
//         ShouldParse("#80FFA0", new RGB(128, 255, 160));
//         ShouldParse("#3B7", new RGB(51, 187, 119));
//     }
//
//     // A helper function for the testing.
//     private void ShouldParse(string color, RGB expected)
//     {
//         Assert.That(parser.Parse(color), Is.EqualTo(expected), $"input: \"{color}\"");
//     }
// }
