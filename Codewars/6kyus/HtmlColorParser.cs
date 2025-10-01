namespace Codewars._6kyus;

// https://www.codewars.com/kata/58b57ae2724e3c63df000006

public struct RGB
{
    // fields
    public byte r,
        g,
        b;

    // constructors
    public RGB(byte r, byte g, byte b)
    {
        this.r = r;
        this.g = g;
        this.b = b;
    }
}

public class HtmlColorParser
{
    // fields
    private readonly IDictionary<string, string> presetColors;

    // constructors
    public HtmlColorParser(IDictionary<string, string> presetColors)
    {
        // Dependency Injection (DI)
        this.presetColors = presetColors;
    }

    // methods
    public RGB Parse(string color)
    {
        // there are three types of inputs
        // 1. 6-digit hexadecimal
        // 1. 3-digit hexadecimal
        // 2. Preset color name

        // we grab the value from the dictionary by key if it's valid
        if (presetColors.TryGetValue(color.ToLower(), out var value))
            color = value;

        // color length could be either 7 or 4
        if (color.Length == 7)
        {
            // convert the string value to hex
            byte[] hexValues = Convert.FromHexString(color.Substring(1));
            return new RGB(hexValues[0], hexValues[1], hexValues[2]);
        }
        else
        {
            // we have to rebuild the string to two digit pieces
            // then convert to hex

            string newColor =
                $"{new string(color[1], 2)}{new string(color[2], 2)}{new string(color[3], 2)}";

            // string newColor = string.Format("#{0}{0}{1}{1}{2}{2}", color[1], color[2], color[3]);
            // string newColor = string.Concat(color.Skip(1).Select(x => new string(x, 2)).ToList());

            byte[] hexValues = Convert.FromHexString(newColor);

            return new RGB(hexValues[0], hexValues[1], hexValues[2]);
        }
    }
}
