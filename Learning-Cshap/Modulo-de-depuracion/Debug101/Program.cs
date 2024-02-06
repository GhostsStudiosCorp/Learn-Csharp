string? readResult;
int startIndex = 0;
bool goodEntry = false;

int[] numbers = { 1, 2, 3, 4, 5 };

// Display the array to the console.
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: { ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

// To calculate a sum of array elements, 
//  prompt the user for the starting element number.
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false)
{
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);

    if (startIndex > 5)
    {
        goodEntry = false;
        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}

// Display the sum and then pause.
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

Console.WriteLine("press Enter to exit");
readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}


/**************************Resumen***************************/
/*
# Visual Studio Code habilita la configuración de puntos de interrupción en el editor de código o en el menú Ejecutar. 
# Las líneas de código del punto de interrupción se marcan con un punto rojo a la izquierda del número de línea.
# 
# Los puntos de interrupción se pueden quitar o deshabilitar con las mismas opciones que se usan para establecerlos. 
# Las operaciones masivas que afectan a todos los puntos de interrupción están disponibles en el menú Ejecutar.
# 
# Los puntos de interrupción condicionales se pueden usar para pausar la ejecución cuando se cumpla una condición especificada 
# o cuando se alcance un "número de llamadas".Los puntos de registro se pueden usar para registrar información en el terminal 
# sin pausar la ejecución ni insertar código.
#
#https://learn.microsoft.com/es-es/training/modules/implement-visual-studio-code-debugging-tools/6-examine-launch-configurations

Atributos de una configuración de inicio
El archivo launch.json incluye una o varias configuraciones de inicio en la lista configurations. Las configuraciones de inicio usan atributos para admitir diferentes escenarios de depuración. Los siguientes atributos son obligatorios para cada configuración de inicio:

name: el nombre descriptivo del lector asignado a la configuración de inicio.
type: el tipo de depurador que se va a usar para la configuración de inicio.
request: el tipo de solicitud de la configuración de inicio.

Nombre
El atributo name especifica el nombre para mostrar de la configuración de inicio. El valor asignado a name aparece en la lista desplegable de configuraciones de inicio (en el panel de controles de la parte superior de la vista EJECUTAR Y DEPURAR).

Tipo
El atributo type especifica el tipo de depurador que se va a usar para la configuración de inicio. Un valor de codeclr especifica el tipo de depurador para las aplicaciones de .NET 5+ y .NET Core (incluidas aplicaciones de C#).

Solicitud
El atributo request especifica el tipo de solicitud de la configuración de inicio. Actualmente se admiten los valores launch y attach.

Consola
El atributo console especifica el tipo de consola que se usa cuando se inicia la aplicación. Las opciones son internalConsole, integratedTerminal, y externalTerminal. El valor predeterminado es internalConsole. Los tipos de consola se definen como:

La configuración internalConsole corresponde al panel CONSOLA DE DEPURACIÓN en el área Paneles debajo del editor de Visual Studio Code.
La configuración integratedTerminal corresponde al panel SALIDA del área Paneles debajo del editor de Visual Studio Code.
La configuración externalTerminal corresponde a una ventana de terminal externa. La aplicación del símbolo del sistema que viene con Windows es un ejemplo de una ventana de terminal.

Nota:
Si tengo mas de una aplicacion de consola debere de modificar los atributos name, console en casode de que necesite entradas de usuarios, prelaunchtask y etc si se considera necesario del file launch.json y modificar el atributo de label en el file task.json
*/
