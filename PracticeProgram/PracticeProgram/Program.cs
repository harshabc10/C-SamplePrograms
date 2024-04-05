/*class program
{
    public static int[] countstring(string s)
    {
        int[] result = new int[128];
        foreach (char c in s)
        {
           result[c]++;
        }
        return result;
        
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string");
        string s = Console.ReadLine();

        int[] ccount = countstring(s);

        for (int i = 0; i < ccount.Length; i++)
        {
            if (ccount[i] > 0)
            {
                Console.WriteLine(ccount[i]);
            }
           
        }


    }
}*/

// remove common elements in array

/*
class program
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 4, 2, 5 };

        foreach (var ele1 in a)
        {
            foreach (var ele2 in b)
            {
                if (ele1.Equals(ele2))
                {
                    
                    Console.WriteLine(ele1);
                }
            }
        }
    }
}*/

// count alphabets in a string

/*class Program
{
    static void Main()
    {
        Console.WriteLine("enter a string");
        string s = Console.ReadLine();
        int charCount = CountAlphabeticCharacters(s);

        Console.WriteLine($"The number of alphabetical characters in the string '{s}' is: {charCount}");
    }

    static int CountAlphabeticCharacters(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (char.IsDigit(c)) // Check if the character is a letter
            {
                count++; // Increment count if it's a letter
            }
        }

        return count;
    }

}*/


//regex concept practice programs

using System.Text.RegularExpressions;

class validation
{

    public bool isANumber(string strNum)
    {
        Regex number = new Regex("[0-9]");
        number.IsMatch(strNum);

    }

    public static void Main()
    {
        validation v = new validation();

        Console.WriteLine("ENTER A NUMBER");
        string str = Console.ReadLine();

        bool result = v.isANumber(str);

        Console.WriteLine($"THE INPUT STRING CONTAINS NUMBER{result}");

        
    }
}




