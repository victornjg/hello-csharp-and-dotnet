using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //var files = Directory.GetFiles(@"c:\Users\victo\source\repos\StoredProceduresApplication", "*.cshtml", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            // exercise 1
            var text = File.ReadAllText("lorem-ipsum-text.txt");
            Console.WriteLine(text);
            var wordsQty = text.Split(" ").Length;
            Console.WriteLine("Number of words: " + wordsQty);

            // exercise 2
            var words = text.Split(" ");
            var longestWord = words[0];
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("Longest word: " + longestWord);
        }
    }
}
