/************************Challenge #1 escritura de código que valida la entrada de enteros********************************************/
// string? read;
// int validNumber = 0;
// bool userEnterValidNumber = false;

// Console.WriteLine("Type a number between 5 - 10");
// do
// {
//     read = Console.ReadLine();
//     if (userEnterValidNumber = int.TryParse(read, out validNumber))
//     {
//         userEnterValidNumber = false;

//         if ((validNumber >= 5) && (validNumber <= 10))
//         {
//             userEnterValidNumber = true;
//         }
//         else
//         {
//             Console.WriteLine("Type a valid number between 5 - 10");
//         }
//     }

// } while (userEnterValidNumber == false);

// Console.WriteLine($"Your input value {validNumber} has been accepted.");

/************************Challenge #2 escritura de código que valida la entrada de cadena********************************************/
// string? rol;
// bool validRol = false;

// Console.WriteLine("Which your rol");

// do
// {
//     rol = Console.ReadLine();

//     if (rol != null)
//     {
//         rol = rol.ToLower().Trim();

//             if(rol == "administrator")
//                 validRol = true;
//             else if (rol == "user")
//                 validRol = true;
//             else if (rol == "manager")
//                 validRol = true;
//             else
//             {
//                 Console.WriteLine($"The role name that you entered, {rol} is not valid. Enter your role name (Administrator, Manager, or User)"); 
//                 validRol = false;
//             }
//     }
// }while (validRol == false);

// Console.WriteLine($"Your input value ({rol}) has been accepted.");





/************************Challenge #3 escritura de código que procesa el contenido de una matriz de cadenas******************************/
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

string myString = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
