using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] textAsChar = text.ToCharArray();
        Array.Reverse(textAsChar);
        string reversed = new string(textAsChar);
        Console.WriteLine(reversed);

        //With StringBuilder
        //StringBuilder sb = new StringBuilder();
        //for (int i = text.Length - 1; i >= 0; i--)
        //{
        //    sb.Append(text[i]);
        //}

        //Console.WriteLine(sb.ToString());

    }
}
