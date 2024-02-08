/*
Materiales de referencia:
Puede encontrar información adicional sobre las propiedades de excepción aquí: https://learn.microsoft.com/dotnet/standard/exceptions/exception-class-and-properties y https://learn.microsoft.com/dotnet/api/system.exception.

Puede encontrar información adicional sobre las excepciones aquí: https://learn.microsoft.com/dotnet/csharp/language-reference/language-specification/exceptions.

Puede encontrar información adicional sobre el uso de tipos de excepciones específicos aquí: https://learn.microsoft.com/dotnet/standard/exceptions/how-to-use-specific-exceptions-in-a-catch-block.

Puede encontrar información adicional sobre el patrón try-finally aquí: https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/try-finally

Puede encontrar información adicional sobre el patrón try-catch-finally aquí: https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/try-catch-finally.

Puede encontrar información adicional sobre cómo limpiar el código mediante finally aquí: https://learn.microsoft.com/dotnet/csharp/fundamentals/exceptions/how-to-execute-cleanup-code-using-finally.
*/

try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;

    try
    {
        checked
        {
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
    }

    string str = null;
    try
    {
        checked
        {
            int length = str.Length;
            Console.WriteLine("String Length: " + length);
        }
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null." + ex.Message);
    }

    int[] numbers = new int[5];
    try
    {
        checked
        {
            numbers[5] = 10;
            Console.WriteLine("Number at index 5: " + numbers[5]);
        }
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error: Index out of range." + ex.Message);
    }

    int num3 = 10;
    int num4 = 0;
    checked
    {
        int result2 = num3 / num4;
        Console.WriteLine("Result: " + result2);
    }
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");