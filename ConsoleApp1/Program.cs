using Figgle;

string item;
int buyPrice;
int sellPrice;
int geLimit;

string askString(string text)
{
    Console.WriteLine(text);
    return (Console.ReadLine());
}


Console.WriteLine(
    FiggleFonts.Standard.Render("RuneScape Flip Calc"));

item = askString("Please provide the item you wish to flip:");
buyPrice = Convert.ToInt32(askString("Buy price:"));
sellPrice = Convert.ToInt32(askString("Sell price:"));
geLimit = Convert.ToInt32(askString("GE Limit:"));

Console.WriteLine($"If you flip {geLimit} {item} for the provided prices you will make {(sellPrice - buyPrice) * geLimit}");



