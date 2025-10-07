namespace Codewars._6kyus;

// https://www.codewars.com/kata/517abf86da9663f1d2000003

public class ConvertToCamelCase
{
    public static string ToCamelCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        // LINQ
        // var result = string.Concat(
        //     str.Split('_')
        //         .SelectMany(part => part.Split('_'))
        //         .Select(part => char.ToUpper(part[0]) + part.Substring(1))
        // );
        //
        // if (char.IsLower(str[0]) && result.Length > 0)
        //     result = char.ToLower(result[0]) + result.Substring(1);
        //
        // return result;

        // other solution
        // return string.Concat(str.Split('-','_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));

        string result = string.Empty;
        string[] underscoreSplit = str.Split('_');

        foreach (string t in underscoreSplit)
        {
            string[] dashSplit = t.Split('-');

            foreach (string t1 in dashSplit)
            {
                result += char.ToUpper(t1[0]) + t1.Substring(1);
            }
        }

        if (char.IsLower(str[0]))
            result = char.ToLower(result[0]) + result.Substring(1);

        return result;
    }
}
