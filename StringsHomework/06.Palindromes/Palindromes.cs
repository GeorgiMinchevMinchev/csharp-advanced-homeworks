using System;
using System.Collections.Generic;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).
            Select(x => x.Trim()).ToArray();
        SortedSet<string> palindromes = new SortedSet<string>();
        foreach (var word in words)
        {
            if (word.Length == 1)
            {
                palindromes.Add(word);
            }
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] == word[word.Length - i - 1])
                {
                    palindromes.Add(word);
                }
            }
        }
        Console.WriteLine(string.Join(", ", palindromes));
    }
}
