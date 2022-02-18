using ebay_Templates;
using NReco.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoperCSVImport
{
    public class CsvShoperMatch
    {
        public string[] csvItem;
        public ItemShoper shoperItem;

        public bool autoMatch = true;
    }

    public class ItemShoper
    {
        public string sku, kodproducenta, ean, tytul;
        public int aktywny;
        public double cena;
        public int ilosc;
    }

    public abstract class ParserAdapter
    {
        public static List<ItemShoper> CzytajMagazynLstr(List<string[]> lstr, bool supressError = true)
        {
            var lista = new List<ItemShoper>();


            foreach(string[] l in lstr)
            {
            retry_point:
                try
                {
                    var record = new ItemShoper
                    {
                        sku = l[0],
                        kodproducenta = l[1],
                        ean = l[2],
                        aktywny = int.Parse(l[3]),
                        cena = double.Parse(l[4].Replace(".", ",")),
                        ilosc = int.Parse(l[5]),
                        tytul = l[6]
                    };

                    lista.Add(record);
                }
                catch (Exception x)
                {
                    if (supressError) continue;

                    var res = MessageBox.Show("Nieprawidłowy format wierszu CSV: \n\n" + x.ToString() + "\n\n" + string.Join(";", l),
                        "Błąd odczytu", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                    if (res == DialogResult.Abort)
                    {
                        break;
                    }
                    else if (res == DialogResult.Retry)
                    {
                        goto retry_point;
                    }
                }
            }

            return lista;
        }

        public static List<ItemShoper> WczytajMagazyn(string plikMag, bool supressError = true)
        {
            var lista = new List<ItemShoper>();

            using (var streamRdr = new StreamReader(plikMag))
            {
                var csvReader = new CsvReader(streamRdr, ";");
                while (csvReader.Read())
                {
                retry_point:
                    try
                    {
                        var l = csvReader;

                        var record = new ItemShoper
                        {
                            sku = l[0],
                            kodproducenta = l[1],
                            ean = l[2],
                            aktywny = int.Parse(l[3]),
                            cena = double.Parse(l[4].Replace(".", ",")),
                            ilosc = int.Parse(l[5]),
                            tytul = l[6]
                        };

                        lista.Add(record);
                    }
                    catch (Exception x)
                    {
                        if (supressError) continue;

                        var res = MessageBox.Show("Nieprawidłowy format wierszu CSV: \n\n" + x.ToString() + "\n\n" + Util1.CsvRTs(";", csvReader),
                            "Błąd odczytu", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                        if (res == DialogResult.Abort)
                        {
                            break;
                        }
                        else if (res == DialogResult.Retry)
                        {
                            goto retry_point;
                        }
                    }
                }
            }
            return lista;
        }

        public static List<string[]> WczytajCSV(string plik)
        {
            List<string[]> prod = new List<string[]>();

            using (var streamRdr = new StreamReader(plik))
            {
                var csvReader = new CsvReader(streamRdr, ";");
                while (csvReader.Read())
                {
                    List<string> vals = new List<string>();

                    for (int i = 0; i < csvReader.FieldsCount; i++)
                    {
                        vals.Add(csvReader[i]);
                    }

                    prod.Add(vals.ToArray());
                }
            }
            return prod;
        }

        public abstract List<CsvShoperMatch> Przetworz(string plikMag, string plikCsv);
        public abstract void Eksport(List<CsvShoperMatch> produkty, CsvWriter cw, bool skipNull = true);
        public abstract CsvShoperMatch Rematch(CsvShoperMatch csm, string plikMagazyn);
        public abstract CsvShoperMatch Rematch(CsvShoperMatch csm, List<ItemShoper> listMagazyn);


    }
}
