string[] pallets = { "B14", "A11", "B12", "A13" };
// 
Console.WriteLine("Sorted...");
Array.Sort(pallets);
// 
/*
// Sort() en C# se utiliza para ordenar los elementos de una lista en un orden 
// ascendente. Este método es parte de la clase List<T> en el espacio de nombres 
// System.Collections.Generic y está diseñado para trabajar con listas de 
// cualquier tipo (T).
// 
// Este método ordena los elementos de la lista en función de la implementación 
// predeterminada de comparación del tipo de elemento almacenado en la lista. 
// Para tipos numéricos o cadenas, la ordenación se realiza según el orden natural 
// (números en orden creciente, cadenas en orden lexicográfico).
*/
// 
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// 
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
/*
// Reverse() en C# se utiliza para invertir el orden de los elementos en una lista. 
// Este método pertenece a la clase List<T> en el espacio de nombres System.Collections.Generic y,
//  al igual que Sort(), está diseñado para trabajar con listas de cualquier tipo (T).
// 
// Este método invierte el orden de los elementos en la lista, de manera que el primer 
// elemento se convierte en el último, el segundo en el penúltimo, y así sucesivamente
*/
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// 
Console.WriteLine("");
// 
Array.Clear(pallets, 0, 2);
/*
// Usar métodos de matriz para borrar y cambiar de tamaño una matriz
// // 
// El método Array.Clear() le permite quitar el contenido de elementos específicos de la matriz y 
// reemplazarlo por el valor predeterminado de la matriz. Por ejemplo, en una matriz string, el 
// valor del elemento borrado se reemplaza por null, cuando se borra un elemento de la matriz int, 
// el reemplazo se realiza con 0 (cero).
// // 
// Cadena vacía frente a cadena nula
// Cuando se usa Array.Clear(), los elementos que borramos ya no hacen referencia a una cadena en 
// memoria; de hecho, los elementos no apuntan absolutamente a nada. Apuntar a la nada es un 
// concepto importante que puede resultar difícil de entender al principio.
// // 
// ¿Y si intenta recuperar el valor de un elemento afectado por el método Array.Clear()? ¿Podría hacerlo?
// // 
// Array.Clear() quitará la referencia a un valor de un elemento de la matriz si existe uno. Para solucionar 
// este error, podría buscar un valor nulo antes de intentar imprimir el valor.
// 
// Para evitar el error, agregue una instrucción if antes de acceder a un elemento de matriz que sea nulo 
// en potencia.
*/
// 
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// 
Console.WriteLine("");
Array.Resize(ref pallets, 6);
/*
// Aquí, va a llamar al método Resize(), y pasará la matriz pallets por referencia 
// mediante la palabra clave ref. Algunas veces, los métodos requieren que se pasen 
// argumentos por valor (comportamiento predeterminado) o por referencia (mediante la palabra clave ref). 
// Los motivos por los que este paso es necesario requieren una explicación larga y 
// complicada sobre cómo se administran los objetos en .NET. algo que desgraciadamente 
// va más allá del ámbito de este tema. En caso de duda, se recomienda consultar IntelliSense 
// o Microsoft Docs para ver ejemplos sobre cómo llamar a un determinado método del modo adecuado.
// 
// En este caso, va a aumentar el tamaño de la matriz pallets de cuatro elementos a 6. 
// Los elementos nuevos se agregan al final de los elementos actuales. Los dos nuevos 
// elementos serán nulos hasta que les asigne un valor.
*/
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
// 
pallets[4] = "C01";
pallets[5] = "C02";
// 
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// 
Console.WriteLine("");
Array.Resize(ref pallets, 3);
/*
¿Se pueden quitar elementos nulos de una matriz?
// 
Si el método Array.Resize() no quita los elementos vacíos de una matriz, ¿existe otro 
método auxiliar que haga el trabajo automáticamente? No. La mejor forma de vaciar elementos 
de una matriz sería contar el número de elementos no nulos recorriendo en iteración cada 
elemento y aumentando una variable (un contador). Luego, habría que crear una segunda 
matriz que fuese del tamaño de la variable del contador. Por último, habría que recorrer 
cada elemento de la matriz original y copiar los valores no nulos en la nueva matriz.
*/
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
// 
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Uso de ToCharArray() para invertir un string
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}