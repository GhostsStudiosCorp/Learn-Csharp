string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (string item in items)
{
    if(item.Length > 4 || item.Length <= 3)
    {
        Console.WriteLine(item + "\t" + "--Error");
    }
    else
        Console.WriteLine(item);
}