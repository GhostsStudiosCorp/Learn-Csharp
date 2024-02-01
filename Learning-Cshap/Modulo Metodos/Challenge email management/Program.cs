string internalDomain = "contoso.com";
string externalDomain = "hayworth.com";

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};


for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email address
    DisplayEmail(twoFirstsCharacteresName: corporate[i, 0], lastName: corporate[i, 1], internalDomain);
}

    Console.WriteLine();

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayEmail(twoFirstsCharacteresName: external[i, 0], lastName: external[i, 1], externalDomain);    
}

void DisplayEmail(string twoFirstsCharacteresName, string lastName,string domain)
{
    string email = twoFirstsCharacteresName.Substring(0, 2) + lastName;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}