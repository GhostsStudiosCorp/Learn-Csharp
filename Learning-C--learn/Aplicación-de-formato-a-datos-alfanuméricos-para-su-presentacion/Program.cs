string first = "Hello";
string second = "World";
Console.WriteLine("{0} {1}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

/*
// Hay algunas aspectos importantes que tener en cuenta sobre este código.

// Los tipos de datos y las variables de un tipo de datos determinado tienen 
// "métodos auxiliares" integrados para facilitar tareas concretas.

//         La cadena literal "{0} {1}!" forma una plantilla, y algunos de sus 
//     elementos se reemplazarán en tiempo de ejecución.

//         El token {0} se reemplaza por el primer argumento después de la 
//     plantilla de cadena, es decir, el valor de la variable first.

//         El token {1} se reemplaza por el segundo argumento después de la 
//     plantilla de cadena, es decir, el valor de la variable second.
*/

Console.WriteLine("{0} {1}!", first, second);

/*
// Algunas observaciones sobre estos ejemplos:

//  Para la primera instrucción Console.WriteLine(), observe que los 
// tokens se pueden organizar en cualquier orden. El código de ejemplo 
// tiene {1} antes de {0}.
//  Para la segunda instrucción Console.WriteLine(), observe que los 
// tokens se pueden reutilizar con tres instancias de {0}. Además, no 
// se usa el segundo argumento de variable, second. Sin embargo, el 
// código todavía se ejecuta sin errores.
*/

/*
Aplicación de formato a valores de moneda
El formato compuesto y la interpolación de cadenas se pueden usar para 
dar formato a valores que se muestran en función de un idioma y una 
referencia cultural concretos. En el ejemplo siguiente, se usa el especificador
 de formato de moneda :C para presentar las variables price y discount 
 como moneda.
*/

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

/*
// Si se agrega :C a los tokens incluidos entre las llaves, se aplica formato
//  de moneda al número, independientemente de si se usa int o decimal.

// [! Nota:] ¿Qué ocurre si no se conoce el país o la región y el idioma? Si
//  ejecuta el código anterior en el editor de .NET "en el explorador", como 
//  TrydotNet, verá la siguiente salida: Price: ¤123.45 (Save ¤50.00). Se ha
//  usado el símbolo ¤ en lugar del símbolo de la moneda de su país o región. 
 
//  Se trata de un símbolo genérico que se usa para indicar un valor de "moneda",
//  con independencia de su tipo. Verá este símbolo en el editor de .NET 
//  porque omite la ubicación actual.
*/

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");

// De forma predeterminada, el especificador de formato numérico N solo 
// muestra dos dígitos después del separador decimal.

// Si quiere mostrar más precisión, puede agregar un número después del 
// especificador. En el código siguiente se mostrarán cuatro dígitos después
// del separador decimal mediante el especificador N4

/*
// Use el especificador de formato P para dar formato a los porcentajes. 
// Agregue un número después para controlar el número de valores que se muestran 
// detrás del separador decimal
*/

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");


/*
// Combinación de enfoques de formato
// Las variables de cadena pueden almacenar cadenas creadas mediante técnicas 
// de formato. En el ejemplo siguiente, se da formato a decimales y resultados
// matemáticos decimales y se almacenan en la cadena yourDiscount con formato 
// compuesto.
*/

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = string.Format("You saves {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";

Console.WriteLine(yourDiscount);

// You saved $7.56 off the regular $67.55 price. A discount of 11.19%! Crazyyyyyyyyyyyy :)

/*
// Resumen

// Estas son algunos de las conclusiones importantes de esta unidad sobre el formato 
// de cadenas:

//     Puede usar el formato compuesto o la interpolación de cadenas para dar formato 
// a las cadenas.

//     Con el formato compuesto, se usa una plantilla de cadena que contiene uno o más
// tokens de reemplazo con el formato {0}. También se proporciona una lista de 
// argumentos que se comparan con los tokens de reemplazo según su orden. El formato 
// compuesto funciona cuando se usa string.Format() o Console.WriteLine().

//     Con la interpolación de cadenas, se usa una plantilla de cadena que contiene 
// los nombres de variable que se quieren reemplazar entre llaves. Se usa la directiva 
// $ antes de la plantilla de cadena para indicar que se quiere interpolar la cadena.

//     Se aplica formato a los valores de moneda mediante un especificador :C.

//     Se aplica formato a los números mediante un especificador :N. La precisión 
// (el número de valores después del separador decimal) se controla mediante un número 
// después de :N, como en {myNumber:N3}.

//     Use el especificador de formato :P para dar formato a los porcentajes.

//     El formato de moneda y número depende de la referencia cultural del usuario 
// final, un código de cinco caracteres que incluye el país o la región y el idioma 
// del usuario (según la configuración del equipo).
*/