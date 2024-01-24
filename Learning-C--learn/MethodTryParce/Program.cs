string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float totalsNumbersValue = 0;
string message = "";

for (int i = 0; i < values.Length; i++)
{
    if (float.TryParse(values[i], out float numberValue))
        totalsNumbersValue += numberValue;
    else
        message += values[i];
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {totalsNumbersValue}");
