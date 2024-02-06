/*
# Objetivos de aprendizaje
# Objetivos de este módulo:
# 
# Examine las categorías básicas de excepciones y revise algunas excepciones comunes del sistema.
# Examine las herramientas de control de excepciones incluidas con C# y las técnicas para estas herramientas.
# Implemente el patrón try-catch en varios escenarios de aplicación de consola.
# 
# https://learn.microsoft.com/es-es/training/modules/implement-exception-handling-c-sharp/1-introduction 

Entre los escenarios comunes que requieren control de excepciones se incluyen:

Entrada del usuario: se pueden producir excepciones cuando el código procesa la entrada del usuario. Por ejemplo, se producen excepciones cuando el valor de entrada tiene un formato incorrecto o está fuera del intervalo.

Procesamiento de datos y cálculos: se pueden producir excepciones cuando el código realiza cálculos de datos o conversiones. Por ejemplo, se producen excepciones cuando el código intenta dividir entre cero, convertir en un tipo no admitido o asignar un valor que está fuera del intervalo.

Operaciones de entrada y salida de archivos: se pueden producir excepciones cuando el código lee o escribe en un archivo. Por ejemplo, se producen excepciones cuando el archivo no existe, el programa no tiene permiso para acceder al archivo o el archivo está en uso por otro proceso.

Operaciones de base de datos: se pueden producir excepciones cuando el código interactúa con una base de datos. Por ejemplo, se producen excepciones cuando se pierde la conexión de base de datos, se produce un error de sintaxis en una instrucción SQL o se produce una infracción de restricción.

Comunicación de red: se pueden producir excepciones cuando el código se comunica a través de una red. Por ejemplo, se producen excepciones cuando se pierde la conexión de red, se excede el tiempo de espera o el servidor remoto devuelve un error.

Otros recursos externos: se pueden producir excepciones cuando el código se comunica con otros recursos externos. Los servicios web, las API de REST o las bibliotecas de terceros pueden producir excepciones por diversos motivos. Por ejemplo, se producen excepciones debido a problemas de conexiones de red, datos con formato incorrecto, etc.

El bloque de código try contiene el código protegido que puede producir una excepción. Si el código de un bloque try produce una excepción, la excepción se controla mediante el correspondiente bloque catch.

El bloque de código catch contiene el código que se ejecuta cuando se detecta una excepción. El bloque catch puede controlar la excepción, registrarla o ignorarla. Se puede configurar un bloque catch para que se ejecute cuando se produzca cualquier tipo de excepción o solo cuando se produzca un tipo de excepción concreto.

El bloque de código finally contiene código que ejecuta si se produce o no una excepción. El bloque finally se usa a menudo para limpiar los recursos asignados en un bloque try. Por ejemplo, asegúrese de que una variable tenga asignado el valor correcto o necesario.

El control de excepciones en una aplicación de C# se implementa normalmente mediante uno o varios de los siguientes patrones:

El patrón try-catch consta de un bloque try seguido de una o varias cláusulas catch. Cada bloque catch se usa para especificar controladores para distintas excepciones.
El patrón try-finally consta de un bloque try seguido de un bloque finally. Normalmente, las instrucciones de un bloque finally se ejecutan cuando el control abandona una instrucción try.
El patrón try-catch-finally implementa los tres tipos de bloques de control de excepciones. Un escenario común para el patrón try-catch-finally es cuando los recursos se obtienen y usan en un bloque try, las circunstancias excepcionales se administran en un bloque catch y los recursos se liberan o se administran de otro modo en el bloque finally.

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
https://learn.microsoft.com/es-es/training/modules/implement-exception-handling-c-sharp/3-examine-compiler-generated-exceptions

Excepciones generadas por el compilador
El runtime de .NET produce excepciones cuando se produce un error en las operaciones básicas. Esta es una breve lista de excepciones de runtime y sus condiciones de error:

ArrayTypeMismatchExceptionSe produce cuando una matriz no puede almacenar un elemento determinado porque el tipo real del elemento es incompatible con el tipo real de la matriz.
DivideByZeroExceptionSe produce cuando se intenta dividir un valor entero entre cero.
FormatException: se produce cuando el formato de un argumento no es válido.
IndexOutOfRangeExceptionSe produce cuando se intenta indexar una matriz y el índice es menor que cero o queda fuera de los límites de la matriz.
InvalidCastExceptionSe produce cuando se produce un error en una conversión explícita de un tipo base en una interfaz o un tipo derivado en tiempo de ejecución.
NullReferenceException: Se produce cuando se intenta hacer referencia a un objeto cuyo valor es nulo.
OverflowException: Se produce cuando se desborda una operación aritmética en un contexto de comprobación.
*/

// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


/*
La mayoría de clases de excepción que se hereda de Exception no añade ninguna funcionalidad adicional, simplemente se hereda de Exception. Por lo tanto, examinar las propiedades de la clase Exception le permite comprender la mayoría de las excepciones y cómo puede usar una excepción en el código.

Estas son las propiedades de la clase Exception:

Data: la propiedad Data contiene datos arbitrarios en pares clave-valor.
HelpLink: la propiedad HelpLink puede usarse para contener una dirección URL (o URN) a un archivo de ayuda que proporciona amplia información sobre la causa de una excepción.
HResult: la propiedad HResult puede usarse para acceder a un valor numérico codificado asignado a una excepción específica.
InnerException: la propiedad InnerException puede usarse para crear y mantener una serie de excepciones durante el control de excepciones.
Message: la propiedad Message proporciona detalles sobre la causa de una excepción.
Source: la propiedad Source puede usarse para tener acceso al nombre de la aplicación o al objeto que provoca el error.
StackTrace: la propiedad StackTrace contiene un seguimiento de la pila que puede usarse para determinar dónde se produjo un error.
TargetSite: la propiedad TargetSite puede usarse para obtener el método que produce la excepción actual.
*/