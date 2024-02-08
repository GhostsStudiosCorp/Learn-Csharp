/*
La creación y la generación de excepciones desde dentro del código es un aspecto importante de la programación de C#. 
La capacidad de generar una excepción en respuesta a una condición, un problema o un error específicos le ayuda a 
garantizar la estabilidad de la aplicación.

Estos son algunos tipos de excepciones comunes que puede usar al crear una excepción:

* ArgumentException o ArgumentNullException: use estos tipos de excepción cuando se llama a un método o constructor con 
 un valor de argumento no válido o una referencia nula.

* InvalidOperationException: use este tipo de excepción cuando las condiciones de funcionamiento de un método no permiten 
 la finalización correcta de una llamada determinada al método.

* NotSupportedException: use este tipo de excepción cuando no se admita una operación o característica.

* IOException: use este tipo de excepción cuando se produzca un error en una operación de entrada y salida.

* FormatException: use este tipo de excepción cuando el formato de una cadena o datos es incorrecto.

*/

ArgumentException invalidArgumentExection = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
throw invalidArgumentExection;

// El proceso para iniciar un objeto de excepción implica crear una instancia de una clase derivada de excepción, 
// configurar opcionalmente las propiedades de la excepción y luego producir el objeto con la palabra clave throw.


// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

bool exit = false;

do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the value returned by AverageOfEvenNumbers in the console
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has ocurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.WriteLine($"Enter a new uppper bound: ");

        string? userResponse = Console.ReadLine();

        if (userResponse.ToLower().Contains("Exit"))
        {
            exit = true;
        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
    }

} while (exit == false);

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}