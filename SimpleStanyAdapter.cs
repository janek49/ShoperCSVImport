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
    public class SimpleStanyAdapter : AdapterBase
    {
        public enum Action
        {
            SKIP_ITEM, BREAK, ACCEPT
        }

        public string filterTitle;
        public int idxID, idxTytul, idxDostepny, idxEAN;

        public TemplateHelper.StanyAdapterConfig config;

        public virtual List<CsvShoperMatch> MatchItems(List<ItemShoper> magazyn, List<CsvShoperMatch> csv, Func<string[], Action> PreCheck = null)
        {
            var lista = new List<CsvShoperMatch>();

            foreach (var emptyMatch in csv)
            {
                var csvLine = emptyMatch.csvItem;

                if (PreCheck != null)
                {
                    var val = PreCheck.Invoke(csvLine);
                    if (val == Action.SKIP_ITEM)
                        goto lbl_no_match;
                    else if (val == Action.BREAK)
                        break;
                }

                string lID = csvLine[idxID];
                string lTytul = csvLine[idxTytul];
                string lEAN = idxEAN >= 0 ? csvLine[idxEAN] : null;

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
                    CsvShoperMatch csm = new CsvShoperMatch();
                    csm.csvItem = csvLine;
                    csm.shoperItem = matches[0];
                    lista.Add(csm);

                    continue;
                }


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
                        ItemShoper ish = frmD.SelectedResult;
                        CsvShoperMatch csm = new CsvShoperMatch();
                        csm.csvItem = csvLine;
                        csm.shoperItem = ish;
                        csm.autoMatch = false;
                        lista.Add(csm);
                        continue;
                    }
                    else if (re == DialogResult.Abort)
                        return null;
                }

            lbl_no_match:
                {
                    CsvShoperMatch csm = new CsvShoperMatch();
                    csm.csvItem = csvLine;
                    csm.shoperItem = null;
                    csm.autoMatch = false;
                    lista.Add(csm);
                }
            }

            return lista;
        }

        public virtual void PreProcessTable(List<string[]> csvTable)
        {

        }


        public virtual bool FiltrujMagazyn(ItemShoper ish)
        {
            return ish.tytul.ToLower().Contains(filterTitle.ToLower());
        }


        public override CsvShoperMatch RematchItem(CsvShoperMatch csm, List<ItemShoper> listMagazyn)
        {
            var result = MatchItems(listMagazyn, new CsvShoperMatch[] { csm }.ToList());

            if (result?.Count == 1)
                return result[0];

            return null;
        }

    }

    public class CenyStanyAdapter : SimpleStanyAdapter
    {
        public int idxCena = -1;
    }
}
