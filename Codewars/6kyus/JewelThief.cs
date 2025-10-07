namespace Codewars._6kyus;

// https://www.codewars.com/kata/5b40a38f6be5d82775000003

public class JewelThief
{
    public static int Crack(Safe safe)
    {
        string firstHalf = GetOnePiece(safe, "click", string.Empty);
        string secondHalf = GetOnePiece(safe, "click-click", firstHalf);
        GetOnePiece(safe, "click-click-click", secondHalf);

        return safe.Open();
    }

    private static string GetOnePiece(Safe safe, string targetSound, string prefix)
    {
        for (int i = 0; i <= 99; i++)
        {
            string number = i.ToString("00");

            string leftCombination = string.IsNullOrEmpty(prefix)
                ? $"L{number}"
                : $"{prefix}-L{number}";

            if (safe.Unlock(leftCombination).Equals(targetSound))
                return leftCombination;

            string rightCombination = string.IsNullOrEmpty(prefix)
                ? $"R{number}"
                : $"{prefix}-R{number}";

            if (safe.Unlock(rightCombination).Equals(targetSound))
                return rightCombination;
        }

        return string.Empty;
    }
}

public class Safe
{
    public string Unlock(string combination)
    {
        return "";
    }

    public int Open()
    {
        return 1;
    }
}
