string input  = "snake";
string inputSentence = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

Console.WriteLine();
Console.WriteLine(inputSentence);
Console.WriteLine(ReverseSentence(inputSentence));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}

string ReverseSentence(string inputSentence)
{
    string result = "";
    string[] words = inputSentence.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}