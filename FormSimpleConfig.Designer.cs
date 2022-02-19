namespace ShoperCSVImport
{
    partial class FormSimpleConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimpleConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDisableZeros = new System.Windows.Forms.CheckBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPriceMultiplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbActivatePrice = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDisableZeros);
            this.groupBox1.Controls.Add(this.nudAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stan magazynowy";
            // 
            // cbDisableZeros
            // 
            this.cbDisableZeros.AutoSize = true;
            this.cbDisableZeros.Checked = true;
            this.cbDisableZeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDisableZeros.Location = new System.Drawing.Point(19, 111);
            this.cbDisableZeros.Name = "cbDisableZeros";
            this.cbDisableZeros.Size = new System.Drawing.Size(145, 22);
            this.cbDisableZeros.TabIndex = 2;
            this.cbDisableZeros.Text = "Wyłącz pozostałe";
            this.cbDisableZeros.UseVisualStyleBackColor = true;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(148, 75);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(213, 24);
            this.nudAmount.TabIndex = 1;
            this.nudAmount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zastąp wartością:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(123, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 24);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "dostępny";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szukaj słowa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPriceMultiplier);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbActivatePrice);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cena";
            // 
            // txtPriceMultiplier
            // 
            this.txtPriceMultiplier.Location = new System.Drawing.Point(163, 73);
            this.txtPriceMultiplier.Name = "txtPriceMultiplier";
            this.txtPriceMultiplier.Size = new System.Drawing.Size(198, 24);
            this.txtPriceMultiplier.TabIndex = 4;
            this.txtPriceMultiplier.Text = "1,38";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Narzut (przelicznik):";
            // 
            // cbActivatePrice
            // 
            this.cbActivatePrice.AutoSize = true;
            this.cbActivatePrice.Location = new System.Drawing.Point(13, 30);
            this.cbActivatePrice.Name = "cbActivatePrice";
            this.cbActivatePrice.Size = new System.Drawing.Size(181, 22);
            this.cbActivatePrice.TabIndex = 3;
            this.cbActivatePrice.Text = "Aktywuj kalkulację ceny";
            this.cbActivatePrice.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Image = global::ShoperCSVImport.Properties.Resources.button_cancel1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(135, 296);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOK.Image = global::ShoperCSVImport.Properties.Resources.apply;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(12, 296);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 35);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Zatwierdź";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormSimpleConfig
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(402, 344);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSimpleConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfiguracja podstawowa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.NumericUpDown nudAmount;
        public System.Windows.Forms.CheckBox cbActivatePrice;
        public System.Windows.Forms.TextBox txtPriceMultiplier;
        public System.Windows.Forms.CheckBox cbDisableZeros;
    }
}