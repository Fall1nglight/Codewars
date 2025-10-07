using Codewars._6kyus;

namespace Tests._6kyus;

// https://www.codewars.com/kata/517abf86da9663f1d2000003

[TestFixture]
public class ConvertToCamelCaseTest
{
    [Test]
    public void KataTests()
    {
        Assert.That(
            ConvertToCamelCase.ToCamelCase("the_stealth_warrior"),
            Is.EqualTo("theStealthWarrior"),
            "Kata.ToCamelCase('the_stealth_warrior')"
        );
        Assert.That(
            ConvertToCamelCase.ToCamelCase("The-Stealth-Warrior"),
            Is.EqualTo("TheStealthWarrior"),
            "Kata.ToCamelCase('The-Stealth-Warrior')"
        );
    }
}
