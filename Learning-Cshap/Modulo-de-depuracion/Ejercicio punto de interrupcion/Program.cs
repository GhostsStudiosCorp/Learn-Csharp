// https://learn.microsoft.com/es-es/training/modules/implement-visual-studio-code-debugging-tools/9-exercise-challenge-debug-code
// https://learn.microsoft.com/es-es/training/modules/implement-visual-studio-code-debugging-tools/12-summary

/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

x = ChangeValue(x);

Console.WriteLine(x);

int ChangeValue(int value) 
{
    return value = 10;    
}