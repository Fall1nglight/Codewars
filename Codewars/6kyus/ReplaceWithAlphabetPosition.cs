namespace Codewars._6kyus;

public class ReplaceWithAlphabetPosition
{
    public static string AlphabetPosition(string text)
    {
        // 1. iterate over the given string
        // 2. check if the current char is letter
        // 3. if it is, get its position in the alphabet and return it
        // 4. if it is NOT, return an empty string
        // 5. filter out empty strings
        // 6. join elements by a space

        var result = string.Join(
            " ",
            text.Select(x =>
                    char.IsLetter(x) ? (char.ToLower(x) - 'a' + 1).ToString() : string.Empty
                )
                .Where(x => !string.IsNullOrEmpty(x))
        );

        return result;

        // better solution, because we convert the text to lowercase in the beginning and filter before iteration
        // return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
    }
}
