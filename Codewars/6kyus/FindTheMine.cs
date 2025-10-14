namespace Codewars._6kyus;

// https://www.codewars.com/kata/528d9adf0e03778b9e00067e

public class FindTheMine
{
    public static Tuple<int, int> MineLocation(int[,] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                if (field[i, j] == 1)
                    return new Tuple<int, int>(i, j);
            }
        }

        return new Tuple<int, int>(0, 0);
    }
}
