// Ejercicio ciclo for :)

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Halaand";

foreach (var name in names) Console.WriteLine(name);