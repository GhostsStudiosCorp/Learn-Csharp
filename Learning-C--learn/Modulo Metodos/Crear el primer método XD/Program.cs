string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateRange();
    ValidateZeroes();
    
    if (validLength && validZeroes && validRange)        
        Console.WriteLine($"{ip} is a valid IPv4 address");    
    else
        Console.WriteLine($"{ip} is an invalid IPv4 address");
}

void ValidateLength()
{    
    validLength = address.Length == 4;
}

void ValidateRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 225)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}

void ValidateZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }

    }
    validZeroes = true;
}