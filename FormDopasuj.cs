using ebay_Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoperCSVImport
{
    public partial class FormDopasuj : Form
    {
        private string lID;
        private string lEAN;
        private string lTytul;
        private List<ItemShoper> matches;

        public ItemShoper SelectedResult;

        public FormDopasuj()
        {
            InitializeComponent();
        }

        public FormDopasuj(string lID, string lEAN, string lTytul, List<ItemShoper> matches) : this()
        {
            this.lID = lID;
            this.lEAN = lEAN;
            this.lTytul = lTytul;
            this.matches = matches;
        }

        private void FormDopasuj_Load(object sender, EventArgs e)
        {
            lblKod.Text = lID;
            lblEAN.Text = lEAN;
            lblTytul.Text = lTytul;

            foreach (ItemShoper ish in matches)
            {
                var lvi = Util1.ListViewItem(ish.sku, ish.kodproducenta, ish.ean, ish.tytul);
                lvi.UseItemStyleForSubItems = false;
                if (lEAN!=null && lEAN.Trim().Length > 0 && ish.ean.Trim() == lEAN.Trim())
                {
                    var ft = new Font(lstDopasuj.Font, FontStyle.Bold);
                    lvi.SubItems[2].Font = ft;
                }
                lstDopasuj.Items.Add(lvi);
            }

            if (lstDopasuj.Items.Count > 0)
                lstDopasuj.Items[0].Selected = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstDopasuj.SelectedItems.Count == 1)
            {
                SelectedResult = matches[lstDopasuj.SelectedItems[0].Index];
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
