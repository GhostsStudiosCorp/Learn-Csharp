// #Uso de TryParse()

// El método TryParse() realiza varias acciones al mismo tiempo:

// *Intenta analizar una cadena en el tipo de datos numérico indicado.
// Si se ejecuta correctamente, almacena el valor convertido en un 
// parámetro out, que se explica en la sección siguiente.

// *Devuelve un valor bool para indicar si la acción se ha podido 
// realizar correctamente o no.

// *Podemos usar el valor booleano devuelto para realizar una acción 
// en el valor (como llevar a cabo algún cálculo), o bien mostrar un mensaje si 
// la operación de análisis no se ha realizado correctamente.

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else 
{
    Console.WriteLine("Unable to report the measurement");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Para llamar a un método con un parámetro out, debe usar la palabra clave 
// out delante de la variable que contiene el valor. El parámetro out se asigna
//  a la variable result en el código (int.TryParse(value, out result). 
//  Después, puede usar el valor que contiene el parámetro out en el resto del 
//  código mediante la variable result.

// El método int.TryParse() devuelve true si se ha convertido con éxito la 
// variable stringvalue en una int; en caso contrario, devuelve false. 
// Así pues, encierre la instrucción en una instrucción if y, después, lleve a 
// cabo la lógica de decisión en consecuencia.

// El valor convertido se almacena en la variable intresult. 
// En la variable int, result se declara y se inicializa antes que esta línea 
// de código, por lo que debería ser accesible tanto dentro de los bloques 
// de código que pertenecen a las instrucciones if y else como fuera de ellos.

// La palabra clave out indica al compilador que el método TryParse() no solo 
// devolverá un valor de la manera tradicional (como valor devuelto), sino 
// que también comunicará una salida mediante este parámetro bidireccional.

// ##Modificación de la variable de cadena a un valor que no se pueda analizar

// Por último, echemos un vistazo al otro escenario, en el que damos intenc
// ionadamente a TryParse() un valor incorrecto que no se pueda convertir en 
// int.

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Puesto que result se define fuera de la instrucción if, se puede acceder a 
// result más adelante en el código fuera de los bloques de código. Por lo 
// tanto, se puede comprobar que haya en result un valor mayor que cero antes 
// de permitir que result + desplazamiento se escriba como salida. La comprobación 
// de que el valor de result sea mayor que cero evita imprimir un valor de 
// desplazamiento después del mensaje Unable to report the measurement..