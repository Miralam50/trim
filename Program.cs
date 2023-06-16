using System;

public class CustomString
{
    public static string Trim(string input)
    {
        int startIndex = 0;
        int endIndex = input.Length - 1;

        while (startIndex <= endIndex && char.IsWhiteSpace(input[startIndex]))
        {
            startIndex++;
        }

        while (endIndex >= startIndex && char.IsWhiteSpace(input[endIndex]))
        {
            endIndex--;
        }

        if (startIndex > endIndex)
        {
            return string.Empty;
        }

        return input.Substring(startIndex, endIndex - startIndex + 1);
    }

    public static string TrimStart(string input)
    {
        int startIndex = 0;

        while (startIndex < input.Length && char.IsWhiteSpace(input[startIndex]))
        {
            startIndex++;
        }

        if (startIndex == input.Length)
        {
            return string.Empty;
        }

        return input.Substring(startIndex);
    }

    public static string TrimEnd(string input)
    {
        int endIndex = input.Length - 1;

        while (endIndex >= 0 && char.IsWhiteSpace(input[endIndex]))
        {
            endIndex--;
        }

        if (endIndex < 0)
        {
            return string.Empty;
        }

        return input.Substring(0, endIndex + 1);
    }
}

class Program
{
    static void Main()
    {
        string input = "   Hello, World!   ";

        string trimmed = CustomString.Trim(input);
        Console.WriteLine("Trimmed: " + trimmed);

        string trimStart = CustomString.TrimStart(input);
        Console.WriteLine("TrimStart: " + trimStart);

        string trimEnd = CustomString.TrimEnd(input);
        Console.WriteLine("TrimEnd: " + trimEnd);
    }
}