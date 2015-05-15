using System;

class StringLength
{
    static void Main()
    {
        string text = Console.ReadLine();
        int textLength = text.Length;
        if (textLength < 20)
        {
            string longerText = text + new string('*', 20 - textLength);
            Console.WriteLine(longerText);
        }
        else
        {
            Console.WriteLine(text.Substring(0, 20));
        }
    }
}
