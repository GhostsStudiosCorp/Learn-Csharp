using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RamdomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}    

void RamdomizeAnimals()
{
    Random random = new Random();
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }

}

string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];

    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Habrá tres escuelas visitantes.

// La Escuela A tiene seis grupos de visitantes (la cantidad predeterminada).
// La Escuela B tiene tres grupos de visitantes.
// La Escuela C tiene dos grupos de visitantes.
// Para cada escuela visitante, realiza las siguientes tareas:

// Aleatorizar los animales.

// Asignar los animales al número correcto de grupos.
// Imprimir el nombre de la escuela.
