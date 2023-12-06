using System.Text;

internal class Program1
{
    private static void Main(string[] args)
    {
    /*Q1
    DateTime date1 = new DateTime(2023, 6, 14);
    DateTime date2 = new DateTime(2023, 6, 20);
    Console.WriteLine(getDays(date1, date2));
    **Q2
    string[] arr1 = { "1a", "a", "2b", "b" };
    string[] result1 = numInStr(arr1);
    Console.WriteLine(string.Join(", ", result1));
    string[] arr2 = { "abc", "abc10" };
    string[] result2 = numInStr(arr2);
    Console.WriteLine(string.Join(", ", result2));
    **Q3
    Console.WriteLine(ReverseOdd("Bananas"));
    Console.WriteLine(ReverseOdd("One two three four"));
    **Q4
    Console.WriteLine(isPandigital(98140723568910));
    Console.WriteLine(isPandigital(90864523148909));
    Console.WriteLine(isPandigital(112233445566778899));
    Q11
    Console.WriteLine(AddNumbers(10,20));
    Console.WriteLine(AddNumbers(0,20));
    Console.WriteLine(AddNumbers(-30,80));
    **Q12
    Console.WriteLine(removeLeadingTrailing("230.000"));
    Console.WriteLine(removeLeadingTrailing("00402"));
    Console.WriteLine(removeLeadingTrailing("03.1400"));
    Console.WriteLine(removeLeadingTrailing("30"));
    **Q13
    Console.WriteLine(secondLargest(new int[] { 10, 40, 30, 20, 50 }));
    Console.WriteLine(secondLargest(new int[] { 25, 143, 89, 13, 105 }));
    Console.WriteLine(secondLargest(new int[] { 54, 23, 11, 17, 10 }));
    **Q14
    Console.WriteLine(isRepdigit(66));
    Console.WriteLine(isRepdigit(0));
    Console.WriteLine(isRepdigit(-11));
    **Q15
    Console.WriteLine(reverseWords(" the sky is blue"));
    Console.WriteLine(reverseWords("hello world! "));
    Console.WriteLine(reverseWords("a good example"));
    **Q16
    Console.WriteLine(sevenBoom(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
    Console.WriteLine(sevenBoom(new int[] { 1, 2, 3, 4, 5, 6, 8 }));
    **Q17
    Console.WriteLine(insertWhitespace("SheWalksToTheBeach"));
    Console.WriteLine(insertWhitespace("MarvinTalksTooMuch"));
    Console.WriteLine(insertWhitespace("TheGreatestUpsetInHistory"));
         */
    }
    static string insertWhitespace(string input)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length - 1; i++)
        {
            result.Append(input[i]);

            if (char.IsLower(input[i]) && char.IsUpper(input[i + 1]))
            {
                result.Append(' ');
            }
        }

        result.Append(input[input.Length - 1]);

        return result.ToString();
    }
    static string sevenBoom(int[] arr)
    {
        if (arr.Any(num => num.ToString().Contains("7")))
        {
            return "Boom!";
        }
        else
        {
            return "there is no 7 in the array";
        }
    }
    static string reverseWords(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(' ', words);
    }
    static bool isRepdigit(int num)
    {
        string numStr = Math.Abs(num).ToString();
        if (numStr.Length <= 1)
        {
            return true;
        }
        char firstDigit = numStr[0];
        foreach (char digit in numStr)
        {
            if (digit != firstDigit)
            {
                return false;
            }
        }

        return true;
    }
    static int secondLargest(int[] nums)
    {
        int firstMax = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int num in nums)
        {
            if (num > firstMax)
            {
                secondMax = firstMax;
                firstMax = num;
            }
            else if (num > secondMax && num != firstMax)
            {
                secondMax = num;
            }
        }

        return secondMax;
    }
    static string removeLeadingTrailing(string n)
    {
        n = n.TrimStart('0');

        if (n.Contains('.'))
        {
            n = n.TrimEnd('0').TrimEnd('.');
        }
        return n.Length == 0 || n == "." ? "0" : n;
    }
    static int AddNumbers(int x, int n)
    {
        return x + n;
    }
    static bool isPandigital(long num)
    {
        string numStr = num.ToString();
        return numStr.Length == 10 && numStr.Distinct().Count() == 10 && numStr.Contains('0');
    }
    static string ReverseOdd(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length % 2 != 0)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
        }
        return string.Join(" ", words);
    }
    static string[] numInStr(string[] arr)
    {
        List<string> result = new List<string>();

        foreach (string str in arr)
        {
            if (str.Any(char.IsDigit))
            {
                result.Add(str);
            }
        }

        return result.ToArray();
    }
    static int getDays(DateTime date1, DateTime date2)
    {
        TimeSpan timeDifference = date2 - date1;
        int daysDifference = timeDifference.Days;
        return Math.Abs(daysDifference);
    }
}