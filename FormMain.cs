using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ebay_Templates;
using NReco.Csv;

namespace ShoperCSVImport
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public Dictionary<ParserAdapter, string> adapters = new Dictionary<ParserAdapter, string>();

        public List<string[]> CurrentMagazynLoaded = new List<string[]>();
        public List<string[]> CurrentCsvFileLoaded = new List<string[]>();
        public List<string[]> CurrentExportPreview = new List<string[]>();

        private void Form1_Load(object sender, EventArgs e)
        {
            adapters.Add(new TeifocStanyAdapter(), "Teifoc");
            adapters.Add(new EitechStanyAdapter(), "Eitech");
            adapters.Add(new HamaStanyAdapter(), "Hama");

            adapters.Add(new StanyAdapter(), "[Ręcznie]");

            foreach (KeyValuePair<ParserAdapter, string> kvp in adapters)
            {
                cmbAdapter.Items.Add(kvp.Value);
            }

            cmbAdapter.SelectedIndex = 0;

            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage4.Enabled = false;
            cbxExportConf.SelectedIndex = 0;
        }

        public List<CsvShoperMatch> wczytaneProdukty = new List<CsvShoperMatch>();


        private ParserAdapter GetSelectedBehindAdapter()
        {
            ParserAdapter sa = adapters.Keys.ElementAt(cmbAdapter.SelectedIndex);
            return sa;
        }

        private StanyAdapter GetAdapter()
        {
            StanyAdapter adp = new StanyAdapter();
            adp.idxTytul = cbxParTitle.SelectedIndex;
            adp.idxID = cbxParIDSKU.SelectedIndex;
            adp.idxDostepny = cbxParAvail.SelectedIndex;
            adp.idxEAN = cbxParEAN.SelectedIndex;
            adp.filterTitle = txtParFilter.Text.ToLower();
            return adp;
        }

        public static bool CANCEL = false;

        private void btnDopasuj_Click(object sender, EventArgs e)
        {
            StanyAdapter adp = GetAdapter();

            var mag = ParserAdapter.CzytajMagazynLstr(CurrentMagazynLoaded);

            var nowa = new List<CsvShoperMatch>();

            foreach (CsvShoperMatch csm in wczytaneProdukty)
            {
                if (CANCEL)
                {
                    CANCEL = false;
                    return;
                }
                var nw = adp.Rematch(csm, mag);
                nowa.Add(nw == null ? csm : nw);
            }

            UpdateListViewFromCsv(nowa);

            lblStatReadInprds.Text = lblStatReadInprds.Tag + " " + lstProdukty.Items.Count;
            lblStatAutoMatch.Text = lblStatAutoMatch.Tag + " " + (lstProdukty.Items.Count - StatMissingMatch - StatManualMatch);
            lblStatManualMatch.Text = lblStatManualMatch.Tag + " " + StatManualMatch;
            lblStatMissingMatch.Text = lblStatMissingMatch.Tag + " " + StatMissingMatch;

        }

        private int StatMissingMatch, StatManualMatch;

        private void UpdateListViewFromCsv(List<CsvShoperMatch> newList = null, bool resize = true, bool fullReset = true)
        {
            StatMissingMatch = 0;
            StatManualMatch = 0;

            lstProdukty.Visible = false;

            if (newList != null)
            {
                wczytaneProdukty.Clear();
                wczytaneProdukty.AddRange(newList);
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

            foreach (CsvShoperMatch csm in wczytaneProdukty)
            {
                if (fullReset)
                {
                    while (lstProdukty.Columns.Count - 4 < csm.csvItem.Length)
                    {
                        lstProdukty.Columns.Add("#Kol. " + (lstProdukty.Columns.Count - 4));
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
                    item.BackColor = Color.FromArgb(255, 100, 100);
                }
                lstProdukty.Items.Add(item);
            }

            if (resize)
            {
                //lstProdukty.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                //lstProdukty.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListViewUtil.ResizeColumnsToViewport(lstProdukty);
            }

            lstProdukty.Visible = true;
        }

        private void btnEksport_Click(object sender, EventArgs e)
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
                    GetAdapter().Eksport(wczytaneProdukty, cw);
                }
                MessageBox.Show("Zapisano plik: " + plik, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lstProdukty_DoubleClick(object sender, EventArgs e)
        {
            if (lstProdukty.SelectedItems.Count == 1)
            {
                int poz = lstProdukty.SelectedItems[0].Index;
                CsvShoperMatch csm = wczytaneProdukty[poz];

                var newCsm = GetAdapter().Rematch(csm, txtMag.Text);
                if (newCsm != null)
                {
                    int idx = wczytaneProdukty.IndexOf(csm);

                    wczytaneProdukty.Remove(csm);
                    wczytaneProdukty.Insert(idx, newCsm);
                    UpdateListViewFromCsv(null, false, false);
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
            CurrentMagazynLoaded = ParserAdapter.WczytajCSV(txtMag.Text);

            ListViewUtil.DisplayStrArrInListView(lstMagazyn, CurrentMagazynLoaded, 100);

            lblMagSize.Text = "Wczytane produkty: " + CurrentMagazynLoaded.Count;

            tabPage2.Enabled = true;
        }




        private void btnRead_Click(object sender, EventArgs e)
        {
            CurrentCsvFileLoaded = ParserAdapter.WczytajCSV(txtPlik.Text);

            ListViewUtil.DisplayStrArrInListView(lstCsvFile, CurrentCsvFileLoaded);

            lblHurtProds.Text = "Wczytane produkty: " + lstCsvFile.Items.Count;

            tabPage3.Enabled = true;

        }

        private void cmbAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StanyAdapter adp = (StanyAdapter)GetSelectedBehindAdapter();
                PrepareParamBoxes();
                txtParFilter.Text = adp.filterTitle;
                cbxParAvail.SelectedIndex = adp.idxDostepny;
                cbxParEAN.SelectedIndex = adp.idxEAN;
                cbxParIDSKU.SelectedIndex = adp.idxID;
                cbxParTitle.SelectedIndex = adp.idxTytul;
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

            for (int i = 0; i < lstProdukty.Columns.Count - 4; i++)
            {
                cbxParAvail.Items.Add("Kolumna " + i);
                cbxParEAN.Items.Add("Kolumna " + i);
                cbxParIDSKU.Items.Add("Kolumna " + i);
                cbxParTitle.Items.Add("Kolumna " + i);
            }
        }
        private void btnJoinTables_Click(object sender, EventArgs e)
        {
            var csmList = new List<CsvShoperMatch>();
            foreach (string[] csv in CurrentCsvFileLoaded)
            {
                CsvShoperMatch csm = new CsvShoperMatch();
                csm.csvItem = csv;
                csmList.Add(csm);
            }
            UpdateListViewFromCsv(csmList);

            cmbAdapter_SelectedIndexChanged(null, null);

            tabPage4.Enabled = true;
        }

        private void btnExportPreview_Click(object sender, EventArgs e)
        {
            CurrentExportPreview = GetAdapter().SoftExport(wczytaneProdukty);
            ListViewUtil.DisplayStrArrInListView(lstExportPrev, CurrentExportPreview);
            btnSaveExport.Enabled = true;
            lblExpPrev.Text = "Wpisy: " + lstExportPrev.Items.Count;
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

            tabPage3.Enabled = true;

            lblHurtProds.Text = "Wczytane produkty: " + lstCsvFile.Items.Count;
        }

    }
}
