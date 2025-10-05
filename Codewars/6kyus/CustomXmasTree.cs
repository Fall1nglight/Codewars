using System.Text;

namespace Codewars._6kyus;

// https://www.codewars.com/kata/5a405ba4e1ce0e1d7800012e

public class CustomXmasTree
{
    public static string CustomChristmasTree(string chars, int n)
    {
        int customIdx = 0;
        StringBuilder sb = new StringBuilder();

        // iterate n times to construct the leaves
        for (int lineNum = 1; lineNum <= n; lineNum++)
        {
            // calculate the number of spaces needed to center the current line
            // the widest line has (n characters + n-1 spaces) = 2*n - 1 total width
            // the current line has (lineNum characters + lineNum-1 spaces) = 2*lineNum - 1 total width
            // to center the line, we need (2*n - 1 - (2*lineNum - 1)) / 2 = n - lineNum spaces
            sb.Append(new string(' ', n - lineNum));

            // construct the current line, which will consist of 'lineNum' chars + separators
            for (int charCount = 0; charCount < lineNum; charCount++)
                sb.Append(
                    chars[customIdx++ % chars.Length] + (charCount < lineNum - 1 ? " " : "\n")
                );
        }

        int trunkSize = n / 3;

        // construct the trunks
        // each trunk will need n-1 spaces to be centered
        for (int i = 0; i < trunkSize; i++)
            sb.Append(new string(' ', n - 1) + (i < trunkSize - 1 ? "|\n" : "|"));

        return sb.ToString();
    }
}
