// Ejercicio #1

/*
Debe crear el código para imprimir un recibo para que el cliente adquiera 
participaciones de un producto de inversión. Las participaciones se adquieren 
automáticamente al final del año en función de una serie de deducciones en la
nómina, por lo que el número de participaciones adquiridas normalmente contiene 
un importe decimal. Para imprimir el recibo, es probable que sea necesario 
combinar de forma precisa datos de tipos diferentes, incluidos valores fraccionarios, 
de moneda y porcentajes.
*/

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3}");
Console.WriteLine($"    Sub Total: {subtotal:C}");
Console.WriteLine($"    Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");

// Ejercicio #2

string input = "Pad left";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentID = "769C";
string payeeName = "Mr. Stephen Ortega";
string amount = "5000.0";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += amount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

// Ejercicio #3

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"{customerName}" + "\n" + $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return" + "\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}." + "\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}" + "\n");


Console.WriteLine("Here's a quick comparison:\n");
// Your logic here
string comparisonMessage = currentProduct.PadRight(20) + $"{currentReturn:P2}".PadRight(10) + $"{currentProfit:C}".PadRight(10);     
Console.WriteLine(comparisonMessage);
comparisonMessage = newProduct.PadRight(20);
comparisonMessage += string.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += string.Format("{0:C}", newProfit).PadRight(10);

Console.WriteLine(comparisonMessage);
