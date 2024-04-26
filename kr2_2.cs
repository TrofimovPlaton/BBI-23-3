using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        string[] centralWords = GetCentralWords(text);

        Console.WriteLine("Центральные слова предложений:");
        foreach (var word in centralWords)
        {
            Console.WriteLine(word);
        }
    }

    static string[] GetCentralWords(string text)
    {
        string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string[] centralWords = new string[sentences.Length];

        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i].Trim();

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int middleIndex = words.Length / 2;

            if (words.Length % 2 != 0 || words.Length == 1)
            {
                centralWords[i] = words[middleIndex];
            }
            else
            {
                centralWords[i] = words[middleIndex - 1];
            }
        }

        return centralWords;
    }
}