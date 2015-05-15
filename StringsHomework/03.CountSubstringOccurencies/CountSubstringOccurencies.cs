using System;

class CountSubstringOccurencies
{
    static void Main()
    {
        string text = Console.ReadLine();
        string search = Console.ReadLine();
        string lowerText = text.ToLower();
        string lowerSearch = search.ToLower();

        int count = 0;
        int index = lowerText.IndexOf(lowerSearch);
        while(index != -1)
        {
            index = lowerText.IndexOf(lowerSearch, index + 1);
            count++;
        }
        Console.WriteLine(count);

        //while (input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) >= 0)
        //{
        //    numOccurences++;
        //    startIndex = input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
        //}
    }
}
