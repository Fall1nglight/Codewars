namespace Codewars._6kyus;

// https://www.codewars.com/kata/54dc6f5a224c26032800005c

public class BookSeller
{
    public static string StockSummary(string[] stock, string[] categories)
    {
        // stock -> represents the bookseller's stocklist
        // categories -> represents the categories on which we have to operate

        // notes:
        // each book has a "code" at least 3 characters long
        //  first character -> category
        // then comes a space
        // positive integer -> number of books in the category

        // task: find the total number of books in the bookseller's
        //  stocklist with the category codes in the provided 'categories' array

        // validation:
        // if any of the input lists is empty return an empty string

        // implementation:
        // - validate input lists, then return string.Empty if any of them is invalid
        // - define an int[] array to store the results which will have the length of categories[]
        // - iterate over stock
        //      - for each book we have extract the category code (first character)
        //      - check the index of the category code in categories[]
        //      - if index is INVALID -> continue iteration and do nothing
        //      - extract the number of books
        //      - if index is VALID -> increment the int[] array's value on the index by the number of books
        // - define an empty string to store the result
        // - iterate from 0 to the length of categories[] or int[] array's length
        // - construct the string to meet the formatting needs
        // - return the result

        // if (stock.Length == 0 || categories.Length == 0)
        //     return string.Empty;
        //
        // int[] sumStock = new int[categories.Length];
        //
        // foreach (string book in stock)
        // {
        //     string catCode = book.Substring(0, 1);
        //     int catCodeIndex = Array.IndexOf(categories, catCode);
        //
        //     if (catCodeIndex == -1)
        //         continue;
        //
        //     int numOfBooks = int.Parse(book.Split(' ')[1]);
        //     sumStock[catCodeIndex] += numOfBooks;
        // }
        //
        // // use StringBuilder for better performance
        // string resultStr = string.Empty;
        //
        // for (int i = 0; i < categories.Length; i++)
        // {
        //     resultStr +=
        //         $"({categories[i]} : {sumStock[i]}){(i < categories.Length - 1 ? " - " : string.Empty)}";
        // }

        // return resultStr;

        // another solution
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (string cat in categories)
            dict[cat] = 0;

        foreach (string book in stock)
        {
            string catCode = book[..1];

            if (dict.ContainsKey(catCode))
                dict[catCode] += int.Parse(book.Split(' ')[1]);
        }

        var result = dict.Select(kvp => $"({kvp.Key} : {kvp.Value})");

        return string.Join(" - ", result);
    }
}
