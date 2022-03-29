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

item = askString("Please provide the item you wish to flip");



