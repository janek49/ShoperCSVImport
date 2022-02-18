using NReco.Csv;
using ShoperCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoperCSVImport
{
    public class StanyAdapter : ParserAdapter
    {
        public string filterTitle;
        public int idxID, idxTytul, idxDostepny, idxEAN;

        public virtual List<CsvShoperMatch> PrzetworzExt(List<ItemShoper> magazyn, List<string[]> csv)
        {
            var lista = new List<CsvShoperMatch>();

            foreach (string[] csvLine in csv)
            {
                string lID = csvLine[idxID];
                string lTytul = csvLine[idxTytul];
                //string lDostepny = csvLine[idxDostepny];
                string lEAN = idxEAN >= 0 ? csvLine[idxEAN] : null;

                bool found = false;

                List<ItemShoper> matches = new List<ItemShoper>();

                if (lEAN != null && lEAN.Trim().Length > 0)
                    foreach (ItemShoper ish in magazyn)
                    {
                        if (ish.ean == lEAN.Trim())
                        {
                            matches.Add(ish);
                        }
                    }

                if (matches.Count == 1)
                {
                    found = true;
                    CsvShoperMatch csm = new CsvShoperMatch();
                    csm.csvItem = csvLine;
                    csm.shoperItem = matches[0];
                    lista.Add(csm);
                }


                if (!found)
                {

                    foreach (ItemShoper ish in magazyn)
                    {
                        if (!FiltrujMagazyn(ish)) continue;

                        if (ish.tytul.ToLower().Contains(lID.ToLower()) || ish.kodproducenta.ToLower().Contains(lID.ToLower()))
                        {
                            if (!matches.Contains(ish))
                                matches.Add(ish);
                        }
                    }

                    if (matches.Count > 0)
                    {
                        FormDopasuj frmD = new FormDopasuj(lID, lEAN, lTytul, matches);
                        var re = frmD.ShowDialog();
                        if (re == DialogResult.OK)
                        {
                            found = true;
                            ItemShoper ish = frmD.SelectedResult;
                            CsvShoperMatch csm = new CsvShoperMatch();
                            csm.csvItem = csvLine;
                            csm.shoperItem = ish;
                            csm.autoMatch = false;
                            lista.Add(csm);
                        }else if(re == DialogResult.Abort)
                        {
                            FormMain.CANCEL = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        CsvShoperMatch csm = new CsvShoperMatch();
                        csm.csvItem = csvLine;
                        csm.shoperItem = null;
                        csm.autoMatch = false;
                        lista.Add(csm);
                    }
                }

            }

            return lista;
        }


        
        public override List<CsvShoperMatch> Przetworz(string plikMag, string plikCsv)
        {
            var magazyn = WczytajMagazyn(plikMag);
            var csv = WczytajCSV(plikCsv);

            return PrzetworzExt(magazyn, csv);
        }

        public virtual bool FiltrujMagazyn(ItemShoper ish)
        {
            return ish.tytul.ToLower().Contains(filterTitle.ToLower());
        }

        public override void Eksport(List<CsvShoperMatch> items, CsvWriter csvWr, bool skipNull = true)
        {
            csvWr.WriteField("product_code");
            csvWr.WriteField("producer_code");
            csvWr.WriteField("stock");
            csvWr.WriteField("active");
            csvWr.WriteField("barcode");
            csvWr.NextRecord();

            foreach (CsvShoperMatch lvi in items)
            {
                if (lvi.shoperItem == null && skipNull)
                {
                    continue;
                }
                csvWr.WriteField(lvi.shoperItem.sku);
                csvWr.WriteField(lvi.csvItem[idxID]);
                int count;
                string ss;
                if (int.TryParse(lvi.csvItem[idxDostepny].Trim(), out count))
                    ss = count.ToString();
                else
                    ss = lvi.csvItem[idxDostepny].Trim() == "dostępny" ? "20" : "0";
                csvWr.WriteField(ss);
                csvWr.WriteField(ss == "0" ? "0" : "1");
                if (idxEAN >= 0)
                {
                    string ean = lvi.shoperItem.ean;
                    string newEan = lvi.csvItem[idxEAN].Trim();

                    if (newEan.Length > 0 && Util.IsValidGtin(newEan))
                        ean = newEan;

                    csvWr.WriteField(ean);
                }
                csvWr.NextRecord();
            }
        }

        public List<string[]> SoftExport(List<CsvShoperMatch> items, bool skipNull = true)
        {
            List<string[]> list = new List<string[]>();

            list.Add(new string[] { "product_code", "producer_code", "stock", "active", "barcode" });
            foreach (CsvShoperMatch lvi in items)
            {
                if (lvi.shoperItem == null && skipNull)
                    continue;

                var row = new string[5];
                row[0] = lvi.shoperItem.sku;
                row[1] = lvi.csvItem[idxID];

                int count;
                string ss;
                if (int.TryParse(lvi.csvItem[idxDostepny].Trim(), out count))
                    ss = count.ToString();
                else
                    ss = lvi.csvItem[idxDostepny].Trim() == "dostępny" ? "20" : "0";
                row[2] = ss;
                row[3] = ss == "0" ? "0" : "1";

                if (idxEAN >= 0)
                {
                    string ean = lvi.shoperItem.ean;
                    string newEan = lvi.csvItem[idxEAN].Trim();

                    if (newEan.Length > 0 && Util.IsValidGtin(newEan))
                        ean = newEan;

                    row[4] = ean;
                }
                else
                {
                    row[5] = "";
                }

                list.Add(row);
            }

            return list;
        }


        public override CsvShoperMatch Rematch(CsvShoperMatch csm, List<ItemShoper> listMagazyn)
        {
            var lista = new List<string[]>();
            lista.Add(csm.csvItem);

            var result = PrzetworzExt(listMagazyn, lista);

            if (result?.Count == 1)
            {
                return result[0];
            }
            return null;
        }


        public override CsvShoperMatch Rematch(CsvShoperMatch csm, string plikMagazyn)
        {
            var magazyn = WczytajMagazyn(plikMagazyn, true);
            return Rematch(csm, magazyn);
        }
    }

    public class CenyStanyAdapter : StanyAdapter
    {
        public int idxCena = -1;

        public override void Eksport(List<CsvShoperMatch> items, CsvWriter cw, bool skipNull = true)
        {
            if (idxCena == -1)
            {
                base.Eksport(items, cw, skipNull);
                return;
            }

            cw.WriteField("product_code");
            cw.WriteField("producer_code");
            cw.WriteField("price");
            cw.WriteField("stock");
            cw.WriteField("active");
            cw.WriteField("barcode");
            cw.NextRecord();

            foreach (CsvShoperMatch lvi in items)
            {
                if (lvi.shoperItem == null && skipNull)
                {
                    continue;
                }
                cw.WriteField(lvi.shoperItem.sku);
                cw.WriteField(lvi.csvItem[idxID]);
                cw.WriteField(lvi.csvItem[idxCena].Replace(",", "."));
                string ss = lvi.csvItem[idxDostepny].Trim() == "dostępny" ? "20" : "0";
                cw.WriteField(ss);
                cw.WriteField(ss == "0" ? "0" : "1");
                
                string ean = lvi.shoperItem.ean;
                string newEan = lvi.csvItem[idxEAN].Trim();
                if (newEan.Length > 0 && Util.IsValidGtin(newEan))
                    ean = newEan;
                cw.WriteField(ean);

                cw.NextRecord();
            }
        }


    }
}
