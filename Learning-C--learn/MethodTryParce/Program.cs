int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int intResult = 0;
decimal decimalResult = 0m;
float floatResult = 0f;

// Solución para result1: Dividir value1 entre value2, mostrar el resultado como int
// Hint: You need to round the result to nearest integer (don't just truncate)
intResult = value1 / (int)value2;

Console.WriteLine($"Divide value1 by value2, display the result as an int: {intResult}");

// Solución para result2: Dividir value2 entre value3, mostrar el resultado como decimal
decimalResult = value2 / (decimal)value3;

Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {decimalResult}");

// Solución para result3: Dividir value3 entre value1, mostrar el resultado como float
floatResult = value3 / (float)value1;

Console.WriteLine($"Divide value3 by value1, display the result as a float: {floatResult}");
/*
# Tags about this lesson
* TryParse_Method
* TryParse_Method_Excersice
* Convert_Data_Excersice
* 
* * Su objetivo era usar varias técnicas distintas para cambiar el tipo de datos de un valor determinado.
* 
* Usa la conversión implícita y se basa en el compilador de C# para realizar conversiones de ampliación. En los 
* casos en los que el compilador no ha podido realizar una conversión implícita, usa conversiones explícitas. 
* Usa el método ToString() para convertir explícitamente un tipo de datos numérico en un tipo de datos string.
* 
* Cuando ha necesitado realizar conversiones de restricción narrowing conversions, ha empleado varias técnicas diferentes. 
* Usa el operador de conversión () cuando la conversión podía realizarse de forma segura y podía aceptar el truncamiento de 
* valores después del decimal. También ha usado el método Convert() cuando quería realizar una conversión y usar reglas de 
* redondeo comunes para llevar a cabo una conversión de restricción.
* 
* Por último, ha utilizado los métodos TryParse() cuando la conversión de un tipo de datos string a un tipo de datos 
* numérico podría producir una excepción de conversión de tipos de datos.
* 
* Sin esta variedad de opciones, sería difícil trabajar en un lenguaje de programación con tipo. Afortunadamente, este
* sistema de tipos y conversión bien ejecutado se puede usar para compilar aplicaciones sin errores.
*
*

*
*
*
*
*
*
*
*
*/