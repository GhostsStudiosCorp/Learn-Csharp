// Hay varias técnicas para realizar una conversión de tipos de datos. Debe escoger la técnica en función de su respuesta a dos preguntas importantes:

// En función del valor, ¿es posible que el intento de cambiar el tipo de datos del valor produzca una excepción en tiempo de ejecución?
// En función del valor, ¿es posible que el intento de cambiar el tipo de datos del valor provoque una pérdida de información?

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

// Los compiladores realizan conversiones seguras
// El compilador de C# detecta un posible problema en el proceso. La variable second es de tipo string, por lo que podría establecerse en otro valor como "hello". Si el compilador de C# intentara convertir "hello" en un número, esto provocaría una excepción en tiempo de ejecución. Para evitar esta posibilidad, el compilador de C# no realiza implícitamente la conversión de string a int.

// Desde la perspectiva del compilador de C#, la operación más segura sería convertir int en un valor string y realizar una concatenación en su lugar.

// Si piensa realizar sumas mediante una cadena, el compilador de C# requiere que tome un control más explícito del proceso de conversión de datos. En otras palabras, le obliga a involucrarse más para que adopte las precauciones adecuadas para abordar la posibilidad de que la conversión pueda producir una excepción.

// Si necesita cambiar un valor del tipo de datos original a un tipo de datos nuevo y el cambio podría producir una excepción en tiempo de ejecución, tiene que realizar una conversión de datos.

// Para realizar la conversión de datos, puede emplear varias técnicas:

// Usar un método auxiliar en el tipo de datos.
// Usar un método auxiliar en la variable.
// Uso de los métodos de la clase Convert

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

// Cualquier valor int puede adaptarse fácilmente dentro de un tipo decimal, de modo que el compilador realiza la conversión.

// El término conversión de ampliación significa que intenta convertir un valor de un tipo de datos que podría contener menos información en un tipo de datos que puede contener más información. En este caso, un valor almacenado en una variable de tipo int convertido en una variable de tipo decimal no pierde información.

// Cuando sepa que va a realizar una conversión de ampliación, puede confiar en la conversión implícita. El compilador controla las conversiones implícitas.

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

// Para realizar una coerción, se usa el operador de coerción () para encerrar un tipo de datos y se coloca junto a la variable que se quiere convertir (ejemplo: (int)myDecimal). Se realiza una conversión explícita al tipo de datos de coerción definido (int).

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// Todas las variables de tipo de datos tienen un método ToString(). Lo que hace el método ToString() depende de cómo se implemente este en un tipo determinado. No obstante, en la mayoría de los primitivos, realiza una conversión de ampliación. Aunque esto no es estrictamente necesario (puesto que podemos basarnos en la conversión implícita en la mayoría de los casos), puede comunicar a otros desarrolladores que comprende lo que está haciendo y que es a propósito.

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

// La mayoría de los tipos de datos numéricos tienen un método Parse(), que convierte una cadena en el tipo de datos especificado.

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// El método ToInt32() tiene 19 versiones sobrecargadas que permiten aceptar prácticamente todos los tipos de datos.

// Aquí hemos usado el método Convert.ToInt32() con una cadena, pero probablemente debería usar TryParse() siempre que sea posible.

// Por lo tanto, ¿cuándo debemos usar la clase Convert? Se recomienda usar la clase Convert para convertir números fraccionarios en números enteros (int) porque redondea de la manera prevista.

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

var lista = new List<Evaluaciones>();