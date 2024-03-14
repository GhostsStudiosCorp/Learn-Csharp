// Ejercicios De Arrays Propuestos Y Resueltos De C#

// 1 ->  Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.

// string[] tenPositions = new string[]{
//     "1",
//     "2",
//     "3",
//     "4",
//     "5",
//     "6",
//     "7",
//     "8",
//     "9",
//     "10",
// };

// foreach(string position in tenPositions)
// {
//     Console.WriteLine(position);
// }

// 2 -> Crea un array de 10 posiciones, pide los valores por consola y muestra el array.

// int[] results = new int[10];
// int searchedValue = 0;

// bool containsValue = Array.Exists(results, element => element == searchedValue);

// Console.Clear();

// for (int i = 0; i < results.Length; i++)
// {
//     Console.WriteLine($"Write the number in the position {i}");
//     try
//     {
//         int num = Convert.ToInt32(Console.ReadLine());
//         results[i] = num;
//     }
//     catch (FormatException ex)
//     {
//         Console.WriteLine($"Error: {ex.Message}");
//     }
// }

// showArray();

// Console.WriteLine("\nEnter any key for exit");
// Console.ReadLine();

// void showArray()
// {
//     Console.WriteLine("Show Data\n");
//     for (int i = 0; i < results.Length; i++)
//     {
//         Console.WriteLine("\t" + $"The positions {i} for results is: " + results[i] + "\n");
//     }
// }


// 3 -> Sumar los valores de un array y mostrar el resultado.

// int[] array = {3412,423,423,12,31,1};
// int result = 0;

// foreach (int item in array)
// {
//     result += item;
// }

// Console.WriteLine($"The result is : {result}");

// 4) Hacer la media de los valores de un array y mostrar el resultado.

// int[] array = {3412,423,423,12,31,1};
// int result = 0;
// int length = array.Length;

// foreach (int item in array)
// {
//     result += item;
// }

// Console.WriteLine($"The media of my array is: {result/length}");

// 5) Pedir un numero por teclado y multiplicar todos los valores de un array y mostrar el array.

int[] array = { 3412, 423, 423, 12, 31, 1 };
int result = 0;
int multiplier = 0;

Console.Clear();
Console.WriteLine("Insert one number");

try
{
    multiplier = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine("Restart an try insert correct characters number");
    Console.WriteLine("Press any key for exit");
    Console.ReadLine();
}


foreach (int item in array)
{
    result += item;
}

Console.WriteLine($"Your total valor array is: {result}");
Console.WriteLine($"Your array value after multiplication is: {result * multiplier}");

Console.WriteLine("Press any key for exit");
Console.ReadLine();
