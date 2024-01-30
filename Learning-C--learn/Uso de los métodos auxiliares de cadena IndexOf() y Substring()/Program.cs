/*
IndexOf() - Encontrar la Posición de un Substring:

Función: Este método busca la primera aparición de un substring dentro de una cadena y devuelve la posición (índice) de la primera ocurrencia.
Cómo Funciona:
Se proporciona el substring que se está buscando como argumento al método.
El método escanea la cadena desde el principio hasta el final en busca de la primera ocurrencia del substring.
Si encuentra el substring, devuelve el índice de la posición donde comienza el substring. Si no lo encuentra, devuelve -1.

Substring(X, Y) - Extraer una Subcadena:

Función: Este método devuelve una subcadena de una cadena existente, comenzando en una posición específica y teniendo una longitud determinada.
Cómo Funciona:
Se especifica el índice de inicio (X) y la longitud deseada (Y) como argumentos al método.
El método crea y devuelve una nueva cadena que consiste en los caracteres desde el índice de inicio hasta el índice de inicio más la longitud especificada.
Si la longitud no se especifica, el método extraerá caracteres hasta el final de la cadena.
*/

string message = "What is the value<span>between the tags</span>";

const string openSpan = "<span>";
const string closeSpan = "</span>"; 

int openPosition = message.IndexOf("<span>");
int closePosition = message.IndexOf("</span>");

openPosition += openSpan.Length;

int length = closePosition - openPosition;
Console.WriteLine(message.Substring(openPosition, length));


//##################################################################################################################################################

string message = "(What if) I am (only interesed) in the last  (set of parentheses)?";
while (true)
{
    int openPosition = message.IndexOf('(');
    if(openPosition == -1) break;

    openPosition += 1;
    int closePosition = message.IndexOf(')');
    int length = closePosition - openPosition;
    Console.WriteLine(message.Substring(openPosition, length));

    message = message.Substring(closePosition + 1);
} 

/*
LastIndexOf() - Encontrar la última posición de un Substring:

Función: Este método busca la última aparición de un substring dentro de una cadena y devuelve la posición (índice) de la última ocurrencia.
Cómo Funciona:
Se proporciona el substring que se está buscando como argumento al método.
El método escanea la cadena desde el final hasta el principio en busca de la última ocurrencia del substring.
Si encuentra el substring, devuelve el índice de la posición donde comienza la última ocurrencia. Si no lo encuentra, devuelve -1.
*/

//##################################################################################################################################################

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
// next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closePosition = 0;

while (true)
{
    int openPosition = message.IndexOfAny(openSymbols);

    if (openPosition == -1) break;

    string currentSymbol = message.Substring(openPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":

            matchingSymbol = ']';
            break;

        case "{":

            matchingSymbol = ']';
            break;

        case "(":

            matchingSymbol = ']';
            break;

    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 
    openPosition += 1;
    closePosition = message.IndexOf(matchingSymbol, openPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closePosition - openPosition;
    Console.WriteLine(message.Substring(openPosition, length));

}

/*
IndexOfAny(char[]) - Encontrar la Posición del Primer Carácter de un Conjunto:

Función: Este método busca la primera aparición de cualquier carácter en un conjunto especificado de caracteres y 
devuelve la posición (índice) de la primera ocurrencia.

Cómo Funciona:
Se proporciona un conjunto de caracteres como argumento al método.
El método escanea la cadena desde el principio hasta el final en busca de la primera ocurrencia de cualquier carácter en el conjunto especificado.
Si encuentra un carácter del conjunto, devuelve el índice de la posición donde se encuentra ese carácter. Si no encuentra ninguno, devuelve -1.
*/

//##################################################################################################################################################

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

/*
StringBuilder.Remove(int startIndex, int length) - Eliminar Caracteres en Posiciones Específicas:

Función: Este método elimina caracteres de una cadena StringBuilder en posiciones específicas.

Cómo Funciona:
Se especifica el índice de inicio (startIndex) y la longitud (length) de la sección que se va a eliminar.
El método modifica la cadena original, eliminando los caracteres desde la posición startIndex hasta la posición startIndex + length - 1.
*/

//##################################################################################################################################################

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--"," ");
message = message.Replace("-","");
Console.WriteLine(message); 

/*
Replace(string oldValue, string newValue) - Reemplazar Subcadena:

Función: Este método reemplaza todas las apariciones de una subcadena específica en una cadena con otra subcadena.
Cómo Funciona:
Se proporciona la subcadena existente (oldValue) que se desea reemplazar y la nueva subcadena (newValue) que se utilizará en lugar de la existente.
El método escanea la cadena y reemplaza todas las ocurrencias de la subcadena existente con la nueva subcadena.
*/