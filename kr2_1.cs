using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        int wordCount = CountWords(text);
        Console.WriteLine($"Количество слов в тексте: {wordCount}");
    }

    static int CountWords(string text)
    {
        text = text.Trim();

        if (text == "")
            return 0;

        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }
}