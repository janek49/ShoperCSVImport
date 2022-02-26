using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;


namespace ShoperCSVImport
{
    public partial class FormExcelReader : Form
    {
        private List<string[]> CurrentSheetLoaded = new List<string[]>();

        public List<string[]> ResultContent;

        public FormExcelReader()
        {
            InitializeComponent();
        }

        private void btnSelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki Excel (*.xls, *.xlsx)|*.xls;*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnReadSheet_Click(object sender, EventArgs e)
        {
            lstContent.Items.Clear();
            lstContent.Columns.Clear();
            cbxTable.Items.Clear();

            using (var stream = File.Open(txtFilePath.Text, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        cbxTable.Items.Add(reader.Name);
                    } while (reader.NextResult()); //następny arkusz

                    cbxTable.SelectedIndex = 0;
                    cbxTable.Enabled = true;
                    btnOpenTable.Enabled = true;
                    btnReadWholeDoc.Enabled = true;
                }
            }
        }

        private void btnOpenTable_Click(object sender, EventArgs e)
        {
            ReadTable(cbxTable.SelectedIndex);
        }

        private void ReadTable(int index, bool wholeTable = false)
        {
            lstContent.Items.Clear();
            lstContent.Columns.Clear();
            CurrentSheetLoaded.Clear();

            lstContent.Hide();
            Cursor = Cursors.WaitCursor;

            using (var stream = File.Open(txtFilePath.Text, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    for (int i = 0; i < index; i++)
                        reader.NextResult(); //przeskocz do wybranego arkusza

                    do
                    {
                        while (reader.Read())
                        {
                            int cols = reader.FieldCount;

                            while (lstContent.Columns.Count < cols)
                                lstContent.Columns.Add("Kolumna " + (lstContent.Columns.Count + 1));

                            string[] row = new string[cols];

                            for (int i = 0; i < cols; i++)
                            {
                                row[i] = reader.GetValue(i)?.ToString();
                            }

                            CurrentSheetLoaded.Add(row);

                            lstContent.Items.Add(new ListViewItem(row));

                        }

                        if (!wholeTable)
                            break;

                    } while (reader.NextResult());

                }
            }

            if (cbRemoveEmptyCols.Checked)
            {
                FixCollumns();
            }

            ListViewUtil.ResizeColumnsToViewport(lstContent);

            lstContent.Show();
            Cursor = Cursors.Default;
            btnAccept.Enabled = true;
        }


        private void FixCollumns()
        {
            int lastCollumn = lstContent.Columns.Count;

            for (int i = lastCollumn - 1; i > 0; i--)
            {
                bool hasVal = false;

                foreach (string[] row in CurrentSheetLoaded)
                {
                    if (row == null)
                    {
                    }
                    else if (row.Length > i != true)
                    {
                    }
                    else if (row[i] == null)
                    {
                    }
                    else if (row[i].Trim().Length == 0)
                    {
                    }
                    else
                    {
                        hasVal = true;
                        break;
                    }
                }

                if (hasVal)
                    return;
                else
                {
                    
                    lstContent.Columns.RemoveAt(lstContent.Columns.Count - 1);
                }
            }
        }

        private void lstContent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lstContent.SelectedItems.Count == 0)
                    return;

                if (MessageBox.Show("Usunąć " + lstContent.SelectedItems.Count + " wierszy?", "Uwaga",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                
                for (int i = lstContent.SelectedItems.Count - 1; i >= 0; i--)
                    lstContent.SelectedItems[i].Remove();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ResultContent = ListViewUtil.SerializeListView(lstContent);
        }

        private void btnReadWholeDoc_Click(object sender, EventArgs e)
        {
            ReadTable(0, true);
        }
    }
}
