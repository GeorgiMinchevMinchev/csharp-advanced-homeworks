using System;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            string escape = "\\u" + ((int)c).ToString("X").PadLeft(4, '0');
            Console.Write(escape);
        }
        Console.WriteLine();
    }
}
