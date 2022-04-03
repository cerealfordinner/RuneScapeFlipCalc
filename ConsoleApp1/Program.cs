using ConsoleApp1;
using Figgle;

static void flipCalc()
{
    int a;
    string item;
    string buyPrice;
    string sellPrice;
    string geLimit;
    ConsoleKeyInfo askTax;
    bool geTax = true;
    int margin;

    bool result;

    Ask ask = new Ask();


    do
    {
        Console.Clear();
        Console.WriteLine(
    FiggleFonts.Standard.Render("RuneScape Flip Calc"));

        item = ask.AskString("Please provide the item you wish to flip:");

        do
        {
            buyPrice = ask.AskString("Buy price:");
            result = int.TryParse(buyPrice, out a);
        } while (!result);

        do
        {
            sellPrice = ask.AskString("Sell price:");
            result = int.TryParse(sellPrice, out a);
        } while (!result);

        do
        {
            geLimit = ask.AskString("GE Limit:");
            result = int.TryParse(geLimit, out a);
        } while (!result);

        //Get console input for GE tax via key
        Console.Write("Does this item have a GE tax (Y/n):");
        if (Console.ReadKey().Key != ConsoleKey.Y)
        {
            geTax = false;
        }

        double intBuy = int.Parse(buyPrice);
        double intSell = int.Parse(sellPrice);
        int limit = int.Parse(geLimit);



        if (geTax == true)
        {
            margin = ((int)(intSell * 0.99) - (int)intBuy);
        } else
        {
            margin = ((int)(intSell) - (int)intBuy);
        }

        Console.WriteLine($"\nIf you flip {geLimit} {item} for the provided prices you will make {margin * limit}");
        
        Console.Write("\n \nRerun?(Y/n)");
    } while ((Console.ReadKey().Key != ConsoleKey.N));
}


flipCalc();

