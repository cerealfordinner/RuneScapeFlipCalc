using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Flip
    {
        public string? Item { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int GELimit { get; set; }
        public bool GETax { get; set; }

        public Flip(string item, int buyPrice, int sellPrice, int geLimit, bool geTax)
        {
            Item = item;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            GELimit = geLimit;
            GETax = geTax;
        }

        public static string FlipCalc(Flip flip)
        {
            int margin;
            string result;

            if (flip.GETax == true)
            {
                margin = ((int)(flip.SellPrice * 0.99) - (int)flip.BuyPrice);
            }
            else
            {
                margin = ((int)(flip.SellPrice) - (int)flip.BuyPrice);
            }

            result = $"If you flip {flip.GELimit} {flip.Item} for the provided price you will make {margin * flip.GELimit}";

            return result;
        }
    }
}
