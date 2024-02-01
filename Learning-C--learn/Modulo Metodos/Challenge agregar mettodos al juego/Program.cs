Random random = new Random();

string? readline;
var play = true;

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{

    // target: el número objetivo aleatorio entre 1 y 5
    int target = random.Next(1, 7);
    // roll: el resultado de una tirada aleatoria de un dado de seis caras
    int roll = random.Next(1, 7);

    while (play)
    {


        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

// ShouldPlay: este método debe recuperar la entrada del usuario y determinar si el usuario quiere volver a jugar
bool ShouldPlay()
{
    readline = Console.ReadLine();

    do
    {
        if (readline != null)
        {
            readline = readline.ToLower();

            if (readline != "y" && readline != "n")
            {
                return play;
            }
            else if (readline == "y")
            {
                PlayGame();
            }
            else
            {
                Console.WriteLine("See you soon ;)");
                play = false;
            }
        }
    } while (play);

    return false;
}

// WinOrLose: este método debe determinar si el jugador ha ganado o perdido.

string WinOrLose(int target, int roll)
{
    string result = "";

    if (target < roll)
    {
        result = "You win";
    }
    else if (target == roll)
    {
        result = "Tie";
    }
    else
    {
        result = "You lose";
    }

    return result;
}