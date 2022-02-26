using ShoperCopy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoperCSVImport
{
    public class TubanAdapter : CenyStanyAdapter
    {
        public TubanAdapter()
        {
            idxID = 2;
            idxTytul = 3;
            idxDostepny = 7;
            idxEAN = 5;
            idxCena = 4;
            filterTitle = "tuban";
        }

        public override void PreProcessTable(List<string[]> csvTable)
        {
            foreach (string[] row in csvTable)
            {
                //napraw ceny promocyjne
                var cena = row[idxCena];
                //format promocji: 100zł50zł (cena zwykła, cena promocyjna)
                if (cena.Contains("zł"))
                {
                    string[] prices = cena.Split(new string[] { "zł" }, StringSplitOptions.RemoveEmptyEntries);
                    if (prices.Length >= 2)
                    {
                        string newPrice = prices[1].Trim();
                        double newPriceD = Util.ParseAnyDouble(newPrice);
                        row[idxCena] = newPriceD.ToString("0.00");
                    }
                }


                //rozdziel sku+ean w jednej komorce na dwie
                var idJoined = row[idxID].Replace("\r", "");

                string ean, idcode;

                if (idJoined.Contains("\n"))
                {
                    string[] split = idJoined.Split('\n');
                    ean = split[split.Length - 1];
                    idcode = split[0].Replace(" ", "");
                }
                else
                {
                    string[] split = idJoined.Split(' ');
                    ean = split[split.Length - 1];

                    string[] shifted = new string[split.Length - 1];
                    Array.Copy(split, shifted, shifted.Length);

                    idcode = string.Join("", shifted);
                }

                if (!Util.IsValidGtin(ean.Trim()))
                {
                    row[idxID] = row[idxID].Replace(" ", "").Trim();
                    continue;
                }

                row[idxID] = idcode.Trim();
                row[idxEAN] = ean.Trim();
            }
        }
    }
}
