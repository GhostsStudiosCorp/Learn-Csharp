/*
Materiales de referencia:
Puede encontrar información adicional sobre el uso de excepciones aquí: https://learn.microsoft.com/dotnet/csharp/fundamentals/exceptions/using-exceptions.

Puede encontrar información adicional sobre la creación y producción aquí: https://learn.microsoft.com/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exception.

Puede encontrar información adicional sobre cómo crear excepciones definidas por el usuario aquí: https://learn.microsoft.com/dotnet/standard/exceptions/how-to-create-user-defined-exceptions.

Puede encontrar información adicional sobre los mensajes de excepción localizados aquí: https://learn.microsoft.com/dotnet/standard/exceptions/how-to-create-localized-exception-messages.

Puede encontrar información adicional sobre cómo producir explícitamente excepciones aquí: https://learn.microsoft.com/dotnet/standard/exceptions/how-to-explicitly-throw-exceptions.

Puede encontrar información adicional sobre el uso de excepciones específicas aquí: https://learn.microsoft.com/dotnet/standard/exceptions/how-to-use-specific-exceptions-in-a-catch-block.
*/

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};


try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.\n");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.\n");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.\n");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message + "\n");
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }

            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}