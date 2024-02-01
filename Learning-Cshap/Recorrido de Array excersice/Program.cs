// El propósito de nivel superior de este código es invertir una cadena y contar el número de veces que aparece un carácter determinado

string originalMesage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMesage.ToCharArray();
Array.Reverse(message);

int x = 0;

foreach (char i in message) 
{ 
    if (i == 'o')
    { 
        x++; 
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times.");