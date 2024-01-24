// https://learn.microsoft.com/

Console.WriteLine($"Signed Integral types:");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types");

Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

int[] data = new int[3];

/*
##La palabra clave new indica al entorno de ejecución de .NET que cree una instancia de la matriz int y,
#después, que se coordine con el sistema operativo para almacenar la matriz de tres valores int en la 
#memoria. El runtime de .NET cumple estas instrucciones y devuelve una dirección de memoria de la nueva 
#matriz int. Por último, la dirección de memoria se almacena en los datos de la variable. Los elementos 
#de la matriz int tienen 0 como valor predeterminado, ya que es el valor predeterminado de int.
*/

/*
##¿Qué hay de diferente en el tipo de datos de cadena de C#?
#
##El tipo de datos string también es un tipo de referencia. Es posible que se pregunte por qué no usamos 
#el operador new cuando declaramos una cadena. Esta es una ventaja que ofrecen los diseñadores de C#. 
#Dado que el tipo de datos string se usa con mucha frecuencia, podemos usar este formato:
*/

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

/*
#En segundo plano, sin embargo, se crea y se inicializa una nueva instancia de System.String en "Hola mundo".
*/

/*
# Resumen
# # Los tipos de valor pueden contener valores más pequeños y se almacenan en la pila. Los tipos de referencia 
# pueden contener valores grandes y, para crear una nueva instancia de un tipo de referencia, se usa el operador new. 
# Las variables de tipo de referencia contienen una referencia (la dirección de memoria) al valor real almacenado 
# en el montón.
# # Los tipos de referencia incluyen matrices, cadenas y clases.
# 
# https://learn.microsoft.com/api/achievements/share/es-es/GuillermoCopello-3737/X2GCRRTY?sharingId=3DEB30AEECE5D091
*/










