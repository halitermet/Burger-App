namespace HEBurgerHouse
{
    partial class ExtraMalzemeEkleme
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
            txtExtraAdi = new TextBox();
            lblextramalzemeadi = new Label();
            lblextramalzemefiyat = new Label();
            btnExtraMalzemeKaydet = new Button();
            nmrExtraFiyat = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmrExtraFiyat).BeginInit();
            SuspendLayout();
            // 
            // txtExtraAdi
            // 
            txtExtraAdi.Location = new Point(163, 40);
            txtExtraAdi.Name = "txtExtraAdi";
            txtExtraAdi.Size = new Size(163, 27);
            txtExtraAdi.TabIndex = 1;
            // 
            // lblextramalzemeadi
            // 
            lblextramalzemeadi.AutoSize = true;
            lblextramalzemeadi.Location = new Point(25, 40);
            lblextramalzemeadi.Name = "lblextramalzemeadi";
            lblextramalzemeadi.Size = new Size(141, 20);
            lblextramalzemeadi.TabIndex = 2;
            lblextramalzemeadi.Text = "Extra Malzeme Adı :";
            // 
            // lblextramalzemefiyat
            // 
            lblextramalzemefiyat.AutoSize = true;
            lblextramalzemefiyat.Location = new Point(25, 84);
            lblextramalzemefiyat.Name = "lblextramalzemefiyat";
            lblextramalzemefiyat.Size = new Size(47, 20);
            lblextramalzemefiyat.TabIndex = 3;
            lblextramalzemefiyat.Text = "Fiyat :";
            // 
            // btnExtraMalzemeKaydet
            // 
            btnExtraMalzemeKaydet.Location = new Point(144, 146);
            btnExtraMalzemeKaydet.Name = "btnExtraMalzemeKaydet";
            btnExtraMalzemeKaydet.Size = new Size(182, 41);
            btnExtraMalzemeKaydet.TabIndex = 4;
            btnExtraMalzemeKaydet.Text = "Extra Malzemeyi Kaydet";
            btnExtraMalzemeKaydet.UseVisualStyleBackColor = true;
            btnExtraMalzemeKaydet.Click += btnExtraMalzemeKaydet_Click;
            // 
            // nmrExtraFiyat
            // 
            nmrExtraFiyat.Location = new Point(163, 84);
            nmrExtraFiyat.Name = "nmrExtraFiyat";
            nmrExtraFiyat.Size = new Size(163, 27);
            nmrExtraFiyat.TabIndex = 5;
            nmrExtraFiyat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ExtraMalzemeEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 203);
            Controls.Add(nmrExtraFiyat);
            Controls.Add(btnExtraMalzemeKaydet);
            Controls.Add(lblextramalzemefiyat);
            Controls.Add(lblextramalzemeadi);
            Controls.Add(txtExtraAdi);
            Name = "ExtraMalzemeEkleme";
            Text = "ExtraMalzemeEkleme";
            ((System.ComponentModel.ISupportInitialize)nmrExtraFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtExtraAdi;
        private Label lblextramalzemeadi;
        private Label lblextramalzemefiyat;
        private Button btnExtraMalzemeKaydet;
        private NumericUpDown nmrExtraFiyat;
    }
}