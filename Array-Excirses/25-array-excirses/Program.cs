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

int[] results = new int[10];
int searchedValue = 0;

bool containsValue = Array.Exists(results, element => element == searchedValue);

Console.Clear();

for (int i = 0; i < results.Length; i++)
{
    Console.WriteLine($"Write the number in the position {i}");
    try
    {
        int num = Convert.ToInt32(Console.ReadLine());
        results[i] = num;
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    if (containsValue)
    {
        
    }
}

showArray();

Console.WriteLine("\nEnter any key for exit");
Console.ReadLine();

void showArray()
{
    Console.WriteLine("Show Data\n");
    for (int i = 0; i < results.Length; i++)
    {
        Console.WriteLine("\t" + $"The positions {i} for results is: " + results[i] + "\n");
    }
}


