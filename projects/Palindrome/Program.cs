using System;
using System.Text.RegularExpressions;


string inputContent = "";

Console.WriteLine("\tIt's a Palindrome");
Console.Write("Type below: ");
string? input = Console.ReadLine();

Palindrome();

void Palindrome()
{
    if (input != null)
    {

        inputContent = Regex.Replace(input, @"[^0-9a-zA-Z]+", "").ToLower();


        char[] inputContentArr = inputContent.ToCharArray();
        Array.Reverse(inputContentArr);
        string reverseContent = new string(inputContentArr);

        if (inputContent == reverseContent)
        {
            Console.WriteLine($"{input} is a palindrome");
        }
        else
        {
            Console.WriteLine($"{input} ain't palindrome");
        }
    }

}

Console.WriteLine("Type any key to exit");
Console.ReadLine();
