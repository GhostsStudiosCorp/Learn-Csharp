const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openPosition = input.IndexOf(openSpan) + openSpan.Length;
int closePosition = input.IndexOf(closeSpan);

int length = closePosition - openPosition;
Console.WriteLine(quantity = input.Substring(openPosition, length));

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove divs tags
const string openDiv = "<div>";
openPosition = input.IndexOf(openDiv);
output = output.Remove(openPosition, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
closePosition = input.IndexOf(closeDiv);
output = "Output: " + output.Remove(closePosition, closeDiv.Length);

Console.WriteLine(output);