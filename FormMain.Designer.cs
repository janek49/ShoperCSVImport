namespace ShoperCSVImport
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMagSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMagazyn = new System.Windows.Forms.ListView();
            this.btnReadWarehouse = new System.Windows.Forms.Button();
            this.txtMag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlikMag = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReadExcel = new System.Windows.Forms.Button();
            this.lstCsvFile = new System.Windows.Forms.ListView();
            this.lblHurtProds = new System.Windows.Forms.Label();
            this.txtPlik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnPlikIn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFilterUnlinked = new System.Windows.Forms.Button();
            this.btnExportTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtParFilter = new System.Windows.Forms.TextBox();
            this.cbxParTitle = new System.Windows.Forms.ComboBox();
            this.cbxParEAN = new System.Windows.Forms.ComboBox();
            this.cbxParIDSKU = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatReadInprds = new System.Windows.Forms.Label();
            this.lblStatMissingMatch = new System.Windows.Forms.Label();
            this.lblStatAutoMatch = new System.Windows.Forms.Label();
            this.lblStatManualMatch = new System.Windows.Forms.Label();
            this.cmbAdapter = new System.Windows.Forms.ComboBox();
            this.btnJoinTables = new System.Windows.Forms.Button();
            this.btnDopasuj = new System.Windows.Forms.Button();
            this.lstProdukty = new System.Windows.Forms.ListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbxParPrice = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxParAvail = new System.Windows.Forms.ComboBox();
            this.btnAutoConfig = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnReadInFromLinks = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnGenExport = new System.Windows.Forms.Button();
            this.btnSaveExport = new System.Windows.Forms.Button();
            this.lstExportPrev = new System.Windows.Forms.ListView();
            this.lblExpPrev = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 752);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMagSize);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lstMagazyn);
            this.tabPage1.Controls.Add(this.btnReadWarehouse);
            this.tabPage1.Controls.Add(this.txtMag);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnPlikMag);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1232, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Krok 1 - Plik magazynu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMagSize
            // 
            this.lblMagSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMagSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagSize.Location = new System.Drawing.Point(749, 55);
            this.lblMagSize.Name = "lblMagSize";
            this.lblMagSize.Size = new System.Drawing.Size(468, 24);
            this.lblMagSize.TabIndex = 12;
            this.lblMagSize.Text = "Wczytane produkty: 0";
            this.lblMagSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Podgląd pliku (pierwsze 100 wierszy):";
            // 
            // lstMagazyn
            // 
            this.lstMagazyn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMagazyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstMagazyn.FullRowSelect = true;
            this.lstMagazyn.HideSelection = false;
            this.lstMagazyn.Location = new System.Drawing.Point(9, 83);
            this.lstMagazyn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMagazyn.Name = "lstMagazyn";
            this.lstMagazyn.Size = new System.Drawing.Size(1214, 608);
            this.lstMagazyn.TabIndex = 10;
            this.lstMagazyn.UseCompatibleStateImageBehavior = false;
            this.lstMagazyn.View = System.Windows.Forms.View.Details;
            // 
            // btnReadWarehouse
            // 
            this.btnReadWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadWarehouse.Image = global::ShoperCSVImport.Properties.Resources.apply1;
            this.btnReadWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadWarehouse.Location = new System.Drawing.Point(1105, 8);
            this.btnReadWarehouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadWarehouse.Name = "btnReadWarehouse";
            this.btnReadWarehouse.Size = new System.Drawing.Size(118, 40);
            this.btnReadWarehouse.TabIndex = 9;
            this.btnReadWarehouse.Text = "Wczytaj";
            this.btnReadWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadWarehouse.UseVisualStyleBackColor = true;
            this.btnReadWarehouse.Click += new System.EventHandler(this.btnReadWarehouse_Click);
            // 
            // txtMag
            // 
            this.txtMag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMag.Location = new System.Drawing.Point(128, 8);
            this.txtMag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMag.Name = "txtMag";
            this.txtMag.Size = new System.Drawing.Size(849, 26);
            this.txtMag.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Plik magazynu:";
            // 
            // btnPlikMag
            // 
            this.btnPlikMag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlikMag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlikMag.Image = global::ShoperCSVImport.Properties.Resources.viewmag1;
            this.btnPlikMag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlikMag.Location = new System.Drawing.Point(983, 8);
            this.btnPlikMag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlikMag.Name = "btnPlikMag";
            this.btnPlikMag.Size = new System.Drawing.Size(116, 40);
            this.btnPlikMag.TabIndex = 7;
            this.btnPlikMag.Text = "Wybierz";
            this.btnPlikMag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlikMag.UseVisualStyleBackColor = true;
            this.btnPlikMag.Click += new System.EventHandler(this.btnPlikMag_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReadExcel);
            this.tabPage2.Controls.Add(this.lstCsvFile);
            this.tabPage2.Controls.Add(this.lblHurtProds);
            this.tabPage2.Controls.Add(this.txtPlik);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnRead);
            this.tabPage2.Controls.Add(this.btnPlikIn);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1232, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Krok 2 - Plik hurtowni";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReadExcel
            // 
            this.btnReadExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReadExcel.Image = global::ShoperCSVImport.Properties.Resources.db_update;
            this.btnReadExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadExcel.Location = new System.Drawing.Point(1102, 11);
            this.btnReadExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadExcel.Name = "btnReadExcel";
            this.btnReadExcel.Size = new System.Drawing.Size(121, 41);
            this.btnReadExcel.TabIndex = 15;
            this.btnReadExcel.Text = "Plik Excel";
            this.btnReadExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadExcel.UseVisualStyleBackColor = true;
            this.btnReadExcel.Click += new System.EventHandler(this.btnReadExcel_Click);
            // 
            // lstCsvFile
            // 
            this.lstCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCsvFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstCsvFile.FullRowSelect = true;
            this.lstCsvFile.HideSelection = false;
            this.lstCsvFile.Location = new System.Drawing.Point(9, 78);
            this.lstCsvFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCsvFile.Name = "lstCsvFile";
            this.lstCsvFile.Size = new System.Drawing.Size(1214, 613);
            this.lstCsvFile.TabIndex = 14;
            this.lstCsvFile.UseCompatibleStateImageBehavior = false;
            this.lstCsvFile.View = System.Windows.Forms.View.Details;
            // 
            // lblHurtProds
            // 
            this.lblHurtProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHurtProds.Location = new System.Drawing.Point(8, 50);
            this.lblHurtProds.Name = "lblHurtProds";
            this.lblHurtProds.Size = new System.Drawing.Size(468, 24);
            this.lblHurtProds.TabIndex = 13;
            this.lblHurtProds.Text = "Wczytane produkty: 0";
            this.lblHurtProds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlik
            // 
            this.txtPlik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPlik.Location = new System.Drawing.Point(163, 12);
            this.txtPlik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlik.Name = "txtPlik";
            this.txtPlik.Size = new System.Drawing.Size(641, 26);
            this.txtPlik.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plik wejściowy CSV:";
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRead.Image = global::ShoperCSVImport.Properties.Resources.apply1;
            this.btnRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRead.Location = new System.Drawing.Point(932, 11);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(118, 41);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Wczytaj";
            this.btnRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnPlikIn
            // 
            this.btnPlikIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlikIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlikIn.Image = global::ShoperCSVImport.Properties.Resources.viewmag1;
            this.btnPlikIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlikIn.Location = new System.Drawing.Point(810, 11);
            this.btnPlikIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlikIn.Name = "btnPlikIn";
            this.btnPlikIn.Size = new System.Drawing.Size(116, 41);
            this.btnPlikIn.TabIndex = 7;
            this.btnPlikIn.Text = "Wybierz";
            this.btnPlikIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlikIn.UseVisualStyleBackColor = true;
            this.btnPlikIn.Click += new System.EventHandler(this.btnPlikIn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFilterUnlinked);
            this.tabPage3.Controls.Add(this.btnExportTable);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.cmbAdapter);
            this.tabPage3.Controls.Add(this.btnJoinTables);
            this.tabPage3.Controls.Add(this.btnDopasuj);
            this.tabPage3.Controls.Add(this.lstProdukty);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1232, 705);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Krok 3 - Powiązania";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFilterUnlinked
            // 
            this.btnFilterUnlinked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterUnlinked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilterUnlinked.Image = global::ShoperCSVImport.Properties.Resources.db_status1;
            this.btnFilterUnlinked.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterUnlinked.Location = new System.Drawing.Point(788, 104);
            this.btnFilterUnlinked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilterUnlinked.Name = "btnFilterUnlinked";
            this.btnFilterUnlinked.Size = new System.Drawing.Size(177, 35);
            this.btnFilterUnlinked.TabIndex = 16;
            this.btnFilterUnlinked.Text = "Filtruj niepowiązane";
            this.btnFilterUnlinked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilterUnlinked.UseVisualStyleBackColor = true;
            this.btnFilterUnlinked.Click += new System.EventHandler(this.btnFilterUnlinked_Click);
            // 
            // btnExportTable
            // 
            this.btnExportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExportTable.Image = global::ShoperCSVImport.Properties.Resources.reload;
            this.btnExportTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportTable.Location = new System.Drawing.Point(809, 66);
            this.btnExportTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportTable.Name = "btnExportTable";
            this.btnExportTable.Size = new System.Drawing.Size(156, 35);
            this.btnExportTable.TabIndex = 17;
            this.btnExportTable.Text = "Eksportuj tabelę";
            this.btnExportTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportTable.UseVisualStyleBackColor = true;
            this.btnExportTable.Click += new System.EventHandler(this.btnExportTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konfiguracja:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtParFilter);
            this.groupBox2.Controls.Add(this.cbxParTitle);
            this.groupBox2.Controls.Add(this.cbxParEAN);
            this.groupBox2.Controls.Add(this.cbxParIDSKU);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(253, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(437, 99);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametry";
            // 
            // txtParFilter
            // 
            this.txtParFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtParFilter.Location = new System.Drawing.Point(266, 61);
            this.txtParFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParFilter.Name = "txtParFilter";
            this.txtParFilter.Size = new System.Drawing.Size(160, 24);
            this.txtParFilter.TabIndex = 22;
            // 
            // cbxParTitle
            // 
            this.cbxParTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxParTitle.FormattingEnabled = true;
            this.cbxParTitle.Location = new System.Drawing.Point(71, 61);
            this.cbxParTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxParTitle.Name = "cbxParTitle";
            this.cbxParTitle.Size = new System.Drawing.Size(141, 26);
            this.cbxParTitle.TabIndex = 21;
            // 
            // cbxParEAN
            // 
            this.cbxParEAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParEAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxParEAN.FormattingEnabled = true;
            this.cbxParEAN.Location = new System.Drawing.Point(266, 27);
            this.cbxParEAN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxParEAN.Name = "cbxParEAN";
            this.cbxParEAN.Size = new System.Drawing.Size(160, 26);
            this.cbxParEAN.TabIndex = 19;
            // 
            // cbxParIDSKU
            // 
            this.cbxParIDSKU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParIDSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxParIDSKU.FormattingEnabled = true;
            this.cbxParIDSKU.Location = new System.Drawing.Point(71, 27);
            this.cbxParIDSKU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxParIDSKU.Name = "cbxParIDSKU";
            this.cbxParIDSKU.Size = new System.Drawing.Size(141, 26);
            this.cbxParIDSKU.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(218, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Filtr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(4, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tytuł:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(219, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "EAN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID/SKU:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblStatReadInprds);
            this.groupBox1.Controls.Add(this.lblStatMissingMatch);
            this.groupBox1.Controls.Add(this.lblStatAutoMatch);
            this.groupBox1.Controls.Add(this.lblStatManualMatch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(971, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(253, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane";
            // 
            // lblStatReadInprds
            // 
            this.lblStatReadInprds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatReadInprds.Location = new System.Drawing.Point(12, 24);
            this.lblStatReadInprds.Name = "lblStatReadInprds";
            this.lblStatReadInprds.Size = new System.Drawing.Size(321, 24);
            this.lblStatReadInprds.TabIndex = 8;
            this.lblStatReadInprds.Tag = "Wczytane produkty:";
            this.lblStatReadInprds.Text = "Wczytane produkty:";
            // 
            // lblStatMissingMatch
            // 
            this.lblStatMissingMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatMissingMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatMissingMatch.Location = new System.Drawing.Point(12, 102);
            this.lblStatMissingMatch.Name = "lblStatMissingMatch";
            this.lblStatMissingMatch.Size = new System.Drawing.Size(321, 24);
            this.lblStatMissingMatch.TabIndex = 11;
            this.lblStatMissingMatch.Tag = "Brak powiązania:";
            this.lblStatMissingMatch.Text = "Brak powiązania:";
            // 
            // lblStatAutoMatch
            // 
            this.lblStatAutoMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatAutoMatch.Location = new System.Drawing.Point(12, 49);
            this.lblStatAutoMatch.Name = "lblStatAutoMatch";
            this.lblStatAutoMatch.Size = new System.Drawing.Size(321, 24);
            this.lblStatAutoMatch.TabIndex = 9;
            this.lblStatAutoMatch.Tag = "Powiązanie automatyczne:";
            this.lblStatAutoMatch.Text = "Powiązanie automatyczne:";
            // 
            // lblStatManualMatch
            // 
            this.lblStatManualMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatManualMatch.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblStatManualMatch.Location = new System.Drawing.Point(12, 75);
            this.lblStatManualMatch.Name = "lblStatManualMatch";
            this.lblStatManualMatch.Size = new System.Drawing.Size(321, 24);
            this.lblStatManualMatch.TabIndex = 10;
            this.lblStatManualMatch.Tag = "Powiązanie ręczne:";
            this.lblStatManualMatch.Text = "Powiązanie ręczne:";
            // 
            // cmbAdapter
            // 
            this.cmbAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbAdapter.FormattingEnabled = true;
            this.cmbAdapter.Location = new System.Drawing.Point(10, 75);
            this.cmbAdapter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAdapter.Name = "cmbAdapter";
            this.cmbAdapter.Size = new System.Drawing.Size(200, 26);
            this.cmbAdapter.TabIndex = 2;
            this.cmbAdapter.SelectedIndexChanged += new System.EventHandler(this.cmbAdapter_SelectedIndexChanged);
            // 
            // btnJoinTables
            // 
            this.btnJoinTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJoinTables.Image = global::ShoperCSVImport.Properties.Resources._2downarrow1;
            this.btnJoinTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJoinTables.Location = new System.Drawing.Point(9, 6);
            this.btnJoinTables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJoinTables.Name = "btnJoinTables";
            this.btnJoinTables.Size = new System.Drawing.Size(163, 37);
            this.btnJoinTables.TabIndex = 7;
            this.btnJoinTables.Text = "1. Przygotuj tabelę";
            this.btnJoinTables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJoinTables.UseVisualStyleBackColor = true;
            this.btnJoinTables.Click += new System.EventHandler(this.btnJoinTables_Click);
            // 
            // btnDopasuj
            // 
            this.btnDopasuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDopasuj.Image = global::ShoperCSVImport.Properties.Resources.blockdevice;
            this.btnDopasuj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDopasuj.Location = new System.Drawing.Point(9, 106);
            this.btnDopasuj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDopasuj.Name = "btnDopasuj";
            this.btnDopasuj.Size = new System.Drawing.Size(119, 35);
            this.btnDopasuj.TabIndex = 5;
            this.btnDopasuj.Text = "2. Zastosuj";
            this.btnDopasuj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDopasuj.UseVisualStyleBackColor = true;
            this.btnDopasuj.Click += new System.EventHandler(this.btnDopasuj_Click);
            // 
            // lstProdukty
            // 
            this.lstProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProdukty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstProdukty.FullRowSelect = true;
            this.lstProdukty.HideSelection = false;
            this.lstProdukty.Location = new System.Drawing.Point(9, 149);
            this.lstProdukty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProdukty.Name = "lstProdukty";
            this.lstProdukty.Size = new System.Drawing.Size(1214, 552);
            this.lstProdukty.TabIndex = 0;
            this.lstProdukty.UseCompatibleStateImageBehavior = false;
            this.lstProdukty.View = System.Windows.Forms.View.Details;
            this.lstProdukty.DoubleClick += new System.EventHandler(this.lstProdukty_DoubleClick);
            this.lstProdukty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstProdukty_KeyUp);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbxParPrice);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.cbxParAvail);
            this.tabPage5.Controls.Add(this.btnAutoConfig);
            this.tabPage5.Controls.Add(this.dataGrid);
            this.tabPage5.Controls.Add(this.btnReadInFromLinks);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.ImageIndex = 4;
            this.tabPage5.Location = new System.Drawing.Point(4, 43);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1232, 705);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Krok 4 - Edycja";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbxParPrice
            // 
            this.cbxParPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxParPrice.FormattingEnabled = true;
            this.cbxParPrice.Location = new System.Drawing.Point(556, 47);
            this.cbxParPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxParPrice.Name = "cbxParPrice";
            this.cbxParPrice.Size = new System.Drawing.Size(141, 26);
            this.cbxParPrice.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(457, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cena:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(457, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Dostępność:";
            // 
            // cbxParAvail
            // 
            this.cbxParAvail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxParAvail.FormattingEnabled = true;
            this.cbxParAvail.Location = new System.Drawing.Point(556, 12);
            this.cbxParAvail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxParAvail.Name = "cbxParAvail";
            this.cbxParAvail.Size = new System.Drawing.Size(141, 26);
            this.cbxParAvail.TabIndex = 20;
            // 
            // btnAutoConfig
            // 
            this.btnAutoConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAutoConfig.Image = global::ShoperCSVImport.Properties.Resources.blockdevice;
            this.btnAutoConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoConfig.Location = new System.Drawing.Point(269, 7);
            this.btnAutoConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAutoConfig.Name = "btnAutoConfig";
            this.btnAutoConfig.Size = new System.Drawing.Size(172, 35);
            this.btnAutoConfig.TabIndex = 26;
            this.btnAutoConfig.Text = "Autokonfiguracja";
            this.btnAutoConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutoConfig.UseVisualStyleBackColor = true;
            this.btnAutoConfig.Click += new System.EventHandler(this.btnAutoConfig_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(6, 97);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1218, 600);
            this.dataGrid.TabIndex = 25;
            // 
            // btnReadInFromLinks
            // 
            this.btnReadInFromLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReadInFromLinks.Image = global::ShoperCSVImport.Properties.Resources._2downarrow1;
            this.btnReadInFromLinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadInFromLinks.Location = new System.Drawing.Point(7, 7);
            this.btnReadInFromLinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadInFromLinks.Name = "btnReadInFromLinks";
            this.btnReadInFromLinks.Size = new System.Drawing.Size(177, 35);
            this.btnReadInFromLinks.TabIndex = 24;
            this.btnReadInFromLinks.Text = "Wczytaj z powiązań";
            this.btnReadInFromLinks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadInFromLinks.UseVisualStyleBackColor = true;
            this.btnReadInFromLinks.Click += new System.EventHandler(this.btnReadInFromLinks_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Arkusz roboczy:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnGenExport);
            this.tabPage4.Controls.Add(this.btnSaveExport);
            this.tabPage4.Controls.Add(this.lstExportPrev);
            this.tabPage4.Controls.Add(this.lblExpPrev);
            this.tabPage4.ImageIndex = 3;
            this.tabPage4.Location = new System.Drawing.Point(4, 43);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(1232, 705);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Krok 5 - Zapis";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnGenExport
            // 
            this.btnGenExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenExport.Image = global::ShoperCSVImport.Properties.Resources.apply2;
            this.btnGenExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenExport.Location = new System.Drawing.Point(9, 8);
            this.btnGenExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenExport.Name = "btnGenExport";
            this.btnGenExport.Size = new System.Drawing.Size(131, 41);
            this.btnGenExport.TabIndex = 21;
            this.btnGenExport.Text = "Generuj plik";
            this.btnGenExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenExport.UseVisualStyleBackColor = true;
            this.btnGenExport.Click += new System.EventHandler(this.btnGenExport_Click);
            // 
            // btnSaveExport
            // 
            this.btnSaveExport.Enabled = false;
            this.btnSaveExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveExport.Image = global::ShoperCSVImport.Properties.Resources.floppy_unmount;
            this.btnSaveExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveExport.Location = new System.Drawing.Point(155, 8);
            this.btnSaveExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveExport.Name = "btnSaveExport";
            this.btnSaveExport.Size = new System.Drawing.Size(110, 41);
            this.btnSaveExport.TabIndex = 20;
            this.btnSaveExport.Text = "Zapisz";
            this.btnSaveExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveExport.UseVisualStyleBackColor = true;
            this.btnSaveExport.Click += new System.EventHandler(this.btnSaveExport_Click);
            // 
            // lstExportPrev
            // 
            this.lstExportPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExportPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstExportPrev.FullRowSelect = true;
            this.lstExportPrev.HideSelection = false;
            this.lstExportPrev.Location = new System.Drawing.Point(9, 57);
            this.lstExportPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstExportPrev.Name = "lstExportPrev";
            this.lstExportPrev.Size = new System.Drawing.Size(1214, 640);
            this.lstExportPrev.TabIndex = 16;
            this.lstExportPrev.UseCompatibleStateImageBehavior = false;
            this.lstExportPrev.View = System.Windows.Forms.View.Details;
            // 
            // lblExpPrev
            // 
            this.lblExpPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpPrev.Location = new System.Drawing.Point(949, 29);
            this.lblExpPrev.Name = "lblExpPrev";
            this.lblExpPrev.Size = new System.Drawing.Size(274, 24);
            this.lblExpPrev.TabIndex = 15;
            this.lblExpPrev.Text = "Wpisy: 0";
            this.lblExpPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kthememgr.png");
            this.imageList1.Images.SetKeyName(1, "vcalendar.png");
            this.imageList1.Images.SetKeyName(2, "kblackbox.png");
            this.imageList1.Images.SetKeyName(3, "download_manager.png");
            this.imageList1.Images.SetKeyName(4, "edit.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 752);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoper Hurtownia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlikMag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDopasuj;
        private System.Windows.Forms.Button btnPlikIn;
        private System.Windows.Forms.ListView lstProdukty;
        private System.Windows.Forms.ComboBox cmbAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMag;
        private System.Windows.Forms.TextBox txtPlik;
        private System.Windows.Forms.Button btnReadWarehouse;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListView lstMagazyn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMagSize;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblHurtProds;
        private System.Windows.Forms.ListView lstCsvFile;
        private System.Windows.Forms.Button btnJoinTables;
        private System.Windows.Forms.Label lblStatManualMatch;
        private System.Windows.Forms.Label lblStatAutoMatch;
        private System.Windows.Forms.Label lblStatReadInprds;
        private System.Windows.Forms.Label lblStatMissingMatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxParEAN;
        private System.Windows.Forms.ComboBox cbxParIDSKU;
        private System.Windows.Forms.ComboBox cbxParTitle;
        private System.Windows.Forms.ComboBox cbxParAvail;
        private System.Windows.Forms.TextBox txtParFilter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lstExportPrev;
        private System.Windows.Forms.Label lblExpPrev;
        private System.Windows.Forms.Button btnSaveExport;
        private System.Windows.Forms.Button btnReadExcel;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReadInFromLinks;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAutoConfig;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxParPrice;
        private System.Windows.Forms.Button btnFilterUnlinked;
        private System.Windows.Forms.Button btnExportTable;
        private System.Windows.Forms.Button btnGenExport;
    }
}

