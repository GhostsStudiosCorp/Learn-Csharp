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