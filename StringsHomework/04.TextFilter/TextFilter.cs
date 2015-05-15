using System;
using System.Linq;
using System.Text;

class TextFilter
{
    static void Main()
    {
        string banList = Console.ReadLine();
        string text = Console.ReadLine();
        string[] banWords = banList.Split(',').Select(x => x.Trim()).ToArray();
        StringBuilder sb = new StringBuilder(text);

        for (int i = 0; i < banWords.Length; i++)
        {
            string asteriks = new string('*', banWords[i].Length);
            sb.Replace(banWords[i], asteriks);
        }
        Console.WriteLine(sb);
    }
}
