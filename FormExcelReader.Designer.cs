namespace ShoperCSVImport
{
    partial class FormExcelReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcelReader));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstContent = new System.Windows.Forms.ListView();
            this.btnOpenTable = new System.Windows.Forms.Button();
            this.btnReadSheet = new System.Windows.Forms.Button();
            this.btnSelFile = new System.Windows.Forms.Button();
            this.cbRemoveEmptyCols = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plik XLS(X):";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(103, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(662, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz arkusz:";
            // 
            // cbxTable
            // 
            this.cbxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTable.Enabled = false;
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.Location = new System.Drawing.Point(120, 55);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(311, 24);
            this.cbxTable.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zawartość arkusza:";
            // 
            // lstContent
            // 
            this.lstContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstContent.FullRowSelect = true;
            this.lstContent.HideSelection = false;
            this.lstContent.Location = new System.Drawing.Point(12, 125);
            this.lstContent.Name = "lstContent";
            this.lstContent.Size = new System.Drawing.Size(987, 543);
            this.lstContent.TabIndex = 8;
            this.lstContent.UseCompatibleStateImageBehavior = false;
            this.lstContent.View = System.Windows.Forms.View.Details;
            this.lstContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstContent_KeyUp);
            // 
            // btnOpenTable
            // 
            this.btnOpenTable.Enabled = false;
            this.btnOpenTable.Image = global::ShoperCSVImport.Properties.Resources._2downarrow2;
            this.btnOpenTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenTable.Location = new System.Drawing.Point(448, 50);
            this.btnOpenTable.Name = "btnOpenTable";
            this.btnOpenTable.Size = new System.Drawing.Size(148, 33);
            this.btnOpenTable.TabIndex = 6;
            this.btnOpenTable.Text = "2. Wczytaj arkusz";
            this.btnOpenTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenTable.UseVisualStyleBackColor = true;
            this.btnOpenTable.Click += new System.EventHandler(this.btnOpenTable_Click);
            // 
            // btnReadSheet
            // 
            this.btnReadSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadSheet.Image = global::ShoperCSVImport.Properties.Resources.window_nofullscreen;
            this.btnReadSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadSheet.Location = new System.Drawing.Point(871, 7);
            this.btnReadSheet.Name = "btnReadSheet";
            this.btnReadSheet.Size = new System.Drawing.Size(128, 33);
            this.btnReadSheet.TabIndex = 3;
            this.btnReadSheet.Text = "1. Załaduj plik";
            this.btnReadSheet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadSheet.UseVisualStyleBackColor = true;
            this.btnReadSheet.Click += new System.EventHandler(this.btnReadSheet_Click);
            // 
            // btnSelFile
            // 
            this.btnSelFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelFile.Image = global::ShoperCSVImport.Properties.Resources.viewmag1;
            this.btnSelFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelFile.Location = new System.Drawing.Point(771, 7);
            this.btnSelFile.Name = "btnSelFile";
            this.btnSelFile.Size = new System.Drawing.Size(94, 33);
            this.btnSelFile.TabIndex = 2;
            this.btnSelFile.Text = "Wybierz";
            this.btnSelFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelFile.UseVisualStyleBackColor = true;
            this.btnSelFile.Click += new System.EventHandler(this.btnSelFile_Click);
            // 
            // cbRemoveEmptyCols
            // 
            this.cbRemoveEmptyCols.AutoSize = true;
            this.cbRemoveEmptyCols.Checked = true;
            this.cbRemoveEmptyCols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveEmptyCols.Location = new System.Drawing.Point(448, 89);
            this.cbRemoveEmptyCols.Name = "cbRemoveEmptyCols";
            this.cbRemoveEmptyCols.Size = new System.Drawing.Size(146, 20);
            this.cbRemoveEmptyCols.TabIndex = 9;
            this.cbRemoveEmptyCols.Text = "Usuń puste kolumny";
            this.cbRemoveEmptyCols.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Enabled = false;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccept.Image = global::ShoperCSVImport.Properties.Resources.apply;
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(871, 76);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(128, 33);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "3. Zatwierdź";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // FormExcelReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 680);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cbRemoveEmptyCols);
            this.Controls.Add(this.lstContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOpenTable);
            this.Controls.Add(this.cbxTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReadSheet);
            this.Controls.Add(this.btnSelFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExcelReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wczytaj plik Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelFile;
        private System.Windows.Forms.Button btnReadSheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.Button btnOpenTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstContent;
        private System.Windows.Forms.CheckBox cbRemoveEmptyCols;
        private System.Windows.Forms.Button btnAccept;
    }
}