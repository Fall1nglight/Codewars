// using Codewars._6kyus;
//
// namespace Tests._6kyus;
//
// [TestFixture]
// public class SimpleHtmlColorParserTest
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
