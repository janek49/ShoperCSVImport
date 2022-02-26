using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ebay_Templates;
using NReco.Csv;
using ShoperCopy;

namespace ShoperCSVImport
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public string MANUAL_ADAPTER_NAME = "[Ręczna konfiguracja]";

        public Dictionary<AdapterBase, string> adapters = new Dictionary<AdapterBase, string>();

        public List<string[]> CurrentMagazynLoaded = new List<string[]>();
        public List<string[]> CurrentCsvFileLoaded = new List<string[]>();
        public List<string[]> CurrentExportPreview = new List<string[]>();

        public Color BgRedColor = Color.FromArgb(255, 100, 100);

        public List<CsvShoperMatch> LoadedShoperCsvMatches = new List<CsvShoperMatch>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "templates";

            foreach (string fileName in Directory.EnumerateFiles(path))
            {
                try
                {
                    TemplateHelper.StanyAdapterConfig cfg = TemplateHelper.ReadConfigFile(fileName);
                    var adp = new SimpleStanyAdapter();
                    adp.idxTytul = cfg.ColumnTitle - 1;
                    adp.idxID = cfg.ColumnID - 1;
                    adp.idxDostepny = cfg.ColumnAvailable - 1;
                    adp.idxEAN = cfg.ColumnEAN - 1;
                    adp.filterTitle = cfg.FilterText.ToLower();
                    adp.config = cfg;
                    adapters.Add(adp, Path.GetFileNameWithoutExtension(fileName));
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                        break;
                }
            }

            adapters.Add(new TubanAdapter(), "TUBAN");

            adapters.Add(new SimpleStanyAdapter(), MANUAL_ADAPTER_NAME);

            foreach (KeyValuePair<AdapterBase, string> kvp in adapters)
            {
                cmbAdapter.Items.Add(kvp.Value);
            }

            cmbAdapter.SelectedIndex = 0;

            tab2ImportCsv.Enabled = false;
            tab3MatchItems.Enabled = false;
            tab4EditRows.Enabled = false;
            tab5ExportFile.Enabled = false;

            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dataGrid.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dataGrid, true, null);
            }
        }


        private AdapterBase GetSelectedBehindAdapter()
        {
            AdapterBase sa = adapters.Keys.ElementAt(cmbAdapter.SelectedIndex);
            return sa;
        }

        private SimpleStanyAdapter CreateChosenAdapter()
        {
            if (cmbAdapter.SelectedItem.ToString() == "TUBAN")
            {
                return new TubanAdapter();
            }
            else
            {
                SimpleStanyAdapter adp = new SimpleStanyAdapter();
                adp.idxTytul = cbxParTitle.SelectedIndex;
                adp.idxID = cbxParIDSKU.SelectedIndex;
                adp.idxDostepny = cbxParAvail.SelectedIndex;
                adp.idxEAN = cbxParEAN.SelectedIndex;
                adp.filterTitle = txtParFilter.Text.ToLower();
                return adp;
            }
        }

        private void btnDopasuj_Click(object sender, EventArgs e)
        {
            SimpleStanyAdapter adapter = CreateChosenAdapter();

            var magazynShoper = AdapterBase.CzytajMagazynLstr(CurrentMagazynLoaded);

            var nowaLista = adapter.MatchItems(magazynShoper, LoadedShoperCsvMatches,
                (csvRow) =>
                {
                    if (csvRow[adapter.idxID].Trim().Length == 0 && cbxSkipID.Checked)
                        return SimpleStanyAdapter.Action.SKIP_ITEM;

                    if (csvRow[adapter.idxEAN].Trim().Length == 0 && cbxSkipEAN.Checked)
                        return SimpleStanyAdapter.Action.SKIP_ITEM;

                    if (csvRow[adapter.idxTytul].Trim().Length == 0 && cbxSkipTitle.Checked)
                        return SimpleStanyAdapter.Action.SKIP_ITEM;

                    return SimpleStanyAdapter.Action.ACCEPT;
                });

            //operacja przerwana
            if (nowaLista == null)
                return;

            UpdateListViewFromCsvMatches(nowaLista);

            lblStatReadInprds.Text = lblStatReadInprds.Tag + " " + lstProdukty.Items.Count;
            lblStatAutoMatch.Text = lblStatAutoMatch.Tag + " " + (lstProdukty.Items.Count - StatMissingMatch - StatManualMatch);
            lblStatManualMatch.Text = lblStatManualMatch.Tag + " " + StatManualMatch;
            lblStatMissingMatch.Text = lblStatMissingMatch.Tag + " " + StatMissingMatch;

            tab4EditRows.Enabled = true;
        }

        private int StatMissingMatch, StatManualMatch;

        private void UpdateListViewFromCsvMatches(List<CsvShoperMatch> newList = null, bool resize = true, bool fullReset = true)
        {
            StatMissingMatch = 0;
            StatManualMatch = 0;

            lstProdukty.Visible = false;

            if (newList != null)
            {
                LoadedShoperCsvMatches.Clear();
                LoadedShoperCsvMatches.AddRange(newList);
            }

            if (fullReset) lstProdukty.Clear();
            lstProdukty.Items.Clear();

            if (fullReset)
            {
                lstProdukty.Columns.Add("Shoper ID");
                lstProdukty.Columns.Add("Shoper EAN");
                lstProdukty.Columns.Add("Shoper Tytuł");
                lstProdukty.Columns.Add("Shoper Cena");
            }

            foreach (CsvShoperMatch csm in LoadedShoperCsvMatches)
            {
                if (fullReset)
                {
                    while (lstProdukty.Columns.Count - 4 < csm.csvItem.Length)
                    {
                        lstProdukty.Columns.Add("#Kol. " + (lstProdukty.Columns.Count - 3));
                    }
                }
                List<object> list = new List<object>();
                list.Add(csm.shoperItem?.sku);
                list.Add(csm.shoperItem?.ean);
                list.Add(csm.shoperItem?.tytul);
                list.Add(csm.shoperItem?.cena);
                list.AddRange(csm.csvItem);

                var item = Util1.ListViewItem(list.ToArray());

                if (!csm.autoMatch)
                {
                    StatManualMatch++;
                    item.BackColor = Color.LightGoldenrodYellow;
                }
                if (csm.shoperItem == null)
                {
                    StatMissingMatch++;
                    StatManualMatch--;
                    item.BackColor = BgRedColor;
                }
                lstProdukty.Items.Add(item);
            }

            if (resize)
                ListViewUtil.ResizeColumnsToViewport(lstProdukty);

            lstProdukty.Visible = true;
        }


        private void lstProdukty_DoubleClick(object sender, EventArgs e)
        {
            if (lstProdukty.SelectedItems.Count == 1)
            {
                int poz = lstProdukty.SelectedItems[0].Index;
                CsvShoperMatch csm = LoadedShoperCsvMatches[poz];
                var mag = AdapterBase.CzytajMagazynLstr(CurrentMagazynLoaded);

                var newCsm = CreateChosenAdapter().RematchItem(csm, mag);
                if (newCsm != null)
                {
                    int idx = LoadedShoperCsvMatches.IndexOf(csm);

                    LoadedShoperCsvMatches.Remove(csm);
                    LoadedShoperCsvMatches.Insert(idx, newCsm);
                    UpdateListViewFromCsvMatches(null, false, false);
                }
            }
        }

        private void btnPlikMag_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki CSV (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtMag.Text = ofd.FileName;
            }
        }

        private void btnPlikIn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki CSV (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPlik.Text = ofd.FileName;
            }
        }



        private void btnReadWarehouse_Click(object sender, EventArgs e)
        {
            CurrentMagazynLoaded = ListViewUtil.ReadCsvArray(txtMag.Text);

            ListViewUtil.DisplayStrArrInListView(lstMagazyn, CurrentMagazynLoaded, 100);

            lblMagSize.Text = "Wczytane produkty: " + CurrentMagazynLoaded.Count;

            tab2ImportCsv.Enabled = true;
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            CurrentCsvFileLoaded = ListViewUtil.ReadCsvArray(txtPlik.Text);

            ListViewUtil.DisplayStrArrInListView(lstCsvFile, CurrentCsvFileLoaded);

            lblHurtProds.Text = "Wczytane produkty: " + lstCsvFile.Items.Count;

            tab3MatchItems.Enabled = true;
        }

        private void cmbAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SimpleStanyAdapter adp = (SimpleStanyAdapter)GetSelectedBehindAdapter();

                gbxAdapterConfig.Enabled = !(adp is TubanAdapter);

                PrepareParamBoxes();
                txtParFilter.Text = adp.filterTitle;
                cbxParAvail.SelectedIndex = adp.idxDostepny;
                cbxParEAN.SelectedIndex = adp.idxEAN;
                cbxParIDSKU.SelectedIndex = adp.idxID;
                cbxParTitle.SelectedIndex = adp.idxTytul;


                if (adp is CenyStanyAdapter)
                    cbxParPrice.SelectedIndex = ((CenyStanyAdapter)adp).idxCena;
                else
                    cbxParPrice.SelectedIndex = adp.config.ColumnPrice - 1;

            }
            catch (Exception)
            {

            }
        }

        private void PrepareParamBoxes()
        {
            cbxParAvail.Items.Clear();
            cbxParEAN.Items.Clear();
            cbxParIDSKU.Items.Clear();
            cbxParTitle.Items.Clear();
            cbxParPrice.Items.Clear();

            for (int i = 1; i < lstProdukty.Columns.Count - 3; i++)
            {
                cbxParAvail.Items.Add("Kolumna " + i);
                cbxParEAN.Items.Add("Kolumna " + i);
                cbxParIDSKU.Items.Add("Kolumna " + i);
                cbxParTitle.Items.Add("Kolumna " + i);
                cbxParPrice.Items.Add("Kolumna " + i);
            }
        }
        private void btnJoinTables_Click(object sender, EventArgs e)
        {
            var inputTable = ListViewUtil.DeepCloneCsvTable(CurrentCsvFileLoaded);

            CreateChosenAdapter().PreProcessTable(inputTable);

            var csmList = new List<CsvShoperMatch>();
            foreach (string[] csv in inputTable)
            {
                CsvShoperMatch csm = new CsvShoperMatch();
                csm.csvItem = csv;
                csmList.Add(csm);
            }
            UpdateListViewFromCsvMatches(csmList);

            cmbAdapter_SelectedIndexChanged(null, null);

            tab5ExportFile.Enabled = true;
        }


        private void btnSaveExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki CSV (*.csv)|*.csv";
            sfd.FileName = "EKSPORT_" + Util1.IsoDateTimeNowFile() + ".csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var plik = sfd.FileName;
                using (var streamWr = new StreamWriter(plik))
                {
                    var cw = new CsvWriter(streamWr, ";");

                    foreach (string[] str in CurrentExportPreview)
                    {
                        foreach (string cell in str)
                        {
                            cw.WriteField(cell);
                        }
                        cw.NextRecord();
                    }

                }
                MessageBox.Show("Zapisano plik: " + plik, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lstExportPrev.Clear();
            btnSaveExport.Enabled = false;
            lblExpPrev.Text = "";
        }

        private void btnFilterUnlinked_Click(object sender, EventArgs e)
        {
            for (int i = lstProdukty.Items.Count - 1; i >= 0; i--)
            {
                if (lstProdukty.Items[i].BackColor != BgRedColor)
                {
                    lstProdukty.Items[i].Remove();
                }
            }
        }

        private void btnExportTable_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Plik CSV (*.csv)|*.csv";
            dlg.FileName = "RAWEXPORT_" + Util1.IsoDateTimeNowFile() + ".csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ListViewUtil.ListViewToCSV(lstProdukty, dlg.FileName, true);
                MessageBox.Show("Zapisano plik: " + dlg.FileName, "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstProdukty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstProdukty.SelectedItems.Count == 0)
                    return;

                if (MessageBox.Show("Usunąć " + lstProdukty.SelectedItems.Count + " wierszy?", "Uwaga",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                for (int i = lstProdukty.SelectedItems.Count - 1; i >= 0; i--)
                    lstProdukty.SelectedItems[i].Remove();
            }
        }



        private void btnReadExcel_Click(object sender, EventArgs e)
        {
            FormExcelReader fer = new FormExcelReader();
            if (fer.ShowDialog() == DialogResult.OK)
            {
                if (fer.ResultContent == null)
                    return;

                CurrentCsvFileLoaded = fer.ResultContent;
                ListViewUtil.DisplayStrArrInListView(lstCsvFile, fer.ResultContent);
            }

            tab3MatchItems.Enabled = true;

            lblHurtProds.Text = "Wczytane produkty: " + lstCsvFile.Items.Count;
        }


        //////////////////////////////////////////////// Tab 4
        //////////////////////////////////////////////// Tab 4
        //////////////////////////////////////////////// Tab 4
        //////////////////////////////////////////////// Tab 4
        //////////////////////////////////////////////// Tab 4
        //////////////////////////////////////////////// Tab 4

        int InternalColumns = 3;

        private void btnAutoConfig_Click(object sender, EventArgs e)
        {
            btnReadInFromLinks.PerformClick();

            FormSimpleConfig frm = new FormSimpleConfig();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            bool skipfirst = true;
            foreach (DataGridViewRow lvi in dataGrid.Rows)
            {
                if (skipfirst)
                {
                    if (frm.cbActivatePrice.Checked)
                    {
                        DataGridViewCell cellHeaderPrice = lvi.Cells[InternalColumns + cbxParPrice.SelectedIndex];
                        cellHeaderPrice.Value = "price";
                    }

                    skipfirst = false;
                    continue;
                }
                DataGridViewCell cellStock = lvi.Cells[InternalColumns + cbxParAvail.SelectedIndex];
                DataGridViewCell cellActive = lvi.Cells[dataGrid.Columns.Count - 1];

                //zmiana stanów
                cellActive.Value = "1";

                if (cellStock.Value.ToString().ToLower().Trim() == frm.txtSearch.Text.ToLower().Trim())
                {
                    cellStock.Value = frm.nudAmount.Value.ToString();

                }
                else
                {
                    cellStock.Value = "0";
                    if (frm.cbDisableZeros.Checked)
                    {
                        cellActive.Value = "0";
                    }
                }

                //zmiana cen
                if (frm.cbActivatePrice.Checked && cbxParPrice.SelectedIndex >= 0)
                {
                    DataGridViewCell cellPriceNetto = lvi.Cells[InternalColumns + cbxParPrice.SelectedIndex];
                    try
                    {
                        double db = Util.ParseAnyDouble(cellPriceNetto.Value.ToString().Trim());
                        double box = Util.ParseAnyDouble(frm.txtPriceMultiplier.Text.Trim());

                        double newprice = db * box;
                        cellPriceNetto.Value = newprice.ToString("0.00").Replace(",", ".");
                    }
                    catch (Exception)
                    {
                    }
                    IncludePrice = true;
                }

                //korekta EAN
                DataGridViewCell cellOldEAN = lvi.Cells[1];
                DataGridViewCell cellNewEAN = lvi.Cells[InternalColumns + cbxParEAN.SelectedIndex];

                string oldEan = cellOldEAN.Value?.ToString().Trim();
                string newEan = cellNewEAN.Value?.ToString().Trim();

                if (!Util.IsValidGtin(oldEan) && !Util.IsValidGtin(newEan))
                {
                    //nic nie rob
                }
                else if (!Util.IsValidGtin(newEan) && Util.IsValidGtin(oldEan))
                {
                    cellNewEAN.Value = oldEan; //brak eanu na liscie, ale mamy z shopera
                }
                else if (!Util.IsValidGtin(oldEan) && Util.IsValidGtin(newEan))
                {
                    cellOldEAN.Value = newEan; //break eanu w shoperze, ale mamy na liscie
                }
            }
        }

        private void btnGenExport_Click(object sender, EventArgs e)
        {
            List<string> fileHeader = new List<string>(new string[] { "product_code", "producer_code", "stock", "active", "barcode" });

            if (IncludePrice)
            {
                fileHeader = new List<string>(new string[] { "product_code", "producer_code", "stock", "active", "price", "barcode" });
            }

            int[] colOrder = new int[fileHeader.Count];

            var row = dataGrid.Rows[0];
            for (int i = 0; i < row.Cells.Count; i++)
            {
                var cell = row.Cells[i];
                string val = cell.Value?.ToString().Trim();

                if (fileHeader.Contains(val))
                    colOrder[fileHeader.IndexOf(val)] = i;
            }

            List<string[]> export = new List<string[]>();

            foreach (DataGridViewRow lvi in dataGrid.Rows)
            {
                var entry = new string[colOrder.Length];
                for (int i = 0; i < colOrder.Length; i++)
                {
                    entry[i] = lvi.Cells[colOrder[i]].Value?.ToString().Trim();
                }
                export.Add(entry);
            }
            CurrentExportPreview = export;
            ListViewUtil.DisplayStrArrInListView(lstExportPrev, CurrentExportPreview);
            btnSaveExport.Enabled = true;

            lblExpPrev.Text = "Wpisy: " + lstExportPrev.Items.Count;
        }

        bool IncludePrice = false;

        private void btnReadInFromLinks_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();

            dataGrid.Hide();

            IncludePrice = false;
            int colId = 1;

            dataGrid.Columns.Add("product_code", "Shoper SKU (product_code)");
            dataGrid.Columns.Add("_shoper_barcode", "Shoper EAN");
            dataGrid.Columns.Add("_shoper_name", "Shoper Nazwa");

            for (int i = 0; i < InternalColumns; i++)
            {
                dataGrid.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
            }

            foreach (CsvShoperMatch csv in LoadedShoperCsvMatches)
            {
                string[] line = csv.csvItem;
                if (line != null && csv.shoperItem != null)
                {
                    while (dataGrid.Columns.Count < line.Length + InternalColumns)
                    {
                        var ch = "_Kolumna" + colId++;
                        dataGrid.Columns.Add(ch, ch);
                    }
                    var strs = new object[] { csv.shoperItem.sku, csv.shoperItem.ean, csv.shoperItem.tytul }.Concat(line).ToArray();
                    dataGrid.Rows.Add(strs);
                }
            }

            dataGrid.Columns.Add("active", "Shoper Aktywny");

            var row = new string[dataGrid.Columns.Count];


            row[0] = "product_code";
            row[InternalColumns + cbxParIDSKU.SelectedIndex] = "producer_code";
            row[InternalColumns + cbxParAvail.SelectedIndex] = "stock";
            row[dataGrid.Columns.Count - 1] = "active";
            row[InternalColumns + cbxParEAN.SelectedIndex] = "barcode";


            dataGrid.Rows.Insert(0, row);


            dataGrid.Show();

        }

    }
}
