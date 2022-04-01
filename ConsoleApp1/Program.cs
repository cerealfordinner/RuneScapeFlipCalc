using Figgle;

static void flipCalc()
{
    int a;
    string item;
    string buyPrice;
    string sellPrice;
    string geLimit;
    bool result;
    string loop = "Y";


    string askString(string text)
    {
        Console.WriteLine(text);
        return (Console.ReadLine());
    }

    do
    {
        Console.WriteLine(
    FiggleFonts.Standard.Render("RuneScape Flip Calc"));

        item = askString("Please provide the item you wish to flip:");

        do
        {
            buyPrice = askString("Buy price:");
            result = int.TryParse(buyPrice, out a);
        } while (!result);

        do
        {
            sellPrice = askString("Sell price:");
            result = int.TryParse(sellPrice, out a);
        } while (!result);

        do
        {
            geLimit = askString("GE Limit:");
            result = int.TryParse(geLimit, out a);
        } while (!result);

        Console.WriteLine($"If you flip {geLimit} {item} for the provided prices you will make {(Convert.ToInt32(sellPrice) - Convert.ToInt32(buyPrice)) * Convert.ToInt32(geLimit)})");
        Console.Write("\n \nRerun?(Y/n)");
        loop = Console.ReadLine();
        Console.Clear();
    } while (loop != "n" || loop != "N");
}


flipCalc();

