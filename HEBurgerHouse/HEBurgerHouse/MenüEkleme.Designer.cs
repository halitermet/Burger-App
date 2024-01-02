namespace HEBurgerHouse
{
    partial class MenüEkleme
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
            nmrMenüEkle = new NumericUpDown();
            btnMenüEkle = new Button();
            lblFiyat = new Label();
            lblMenüEkle = new Label();
            txtMenüEkleAdi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nmrMenüEkle).BeginInit();
            SuspendLayout();
            // 
            // nmrMenüEkle
            // 
            nmrMenüEkle.Location = new Point(158, 82);
            nmrMenüEkle.Name = "nmrMenüEkle";
            nmrMenüEkle.Size = new Size(148, 27);
            nmrMenüEkle.TabIndex = 10;
            // 
            // btnMenüEkle
            // 
            btnMenüEkle.Location = new Point(140, 149);
            btnMenüEkle.Name = "btnMenüEkle";
            btnMenüEkle.Size = new Size(166, 29);
            btnMenüEkle.TabIndex = 9;
            btnMenüEkle.Text = "Menüyü Kaydet";
            btnMenüEkle.UseVisualStyleBackColor = true;
            btnMenüEkle.Click += btnMenüEkle_Click;
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(48, 84);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(47, 20);
            lblFiyat.TabIndex = 8;
            lblFiyat.Text = "Fiyat :";
            // 
            // lblMenüEkle
            // 
            lblMenüEkle.AutoSize = true;
            lblMenüEkle.Location = new Point(48, 38);
            lblMenüEkle.Name = "lblMenüEkle";
            lblMenüEkle.Size = new Size(80, 20);
            lblMenüEkle.TabIndex = 7;
            lblMenüEkle.Text = "Menü Adı :";
            // 
            // txtMenüEkleAdi
            // 
            txtMenüEkleAdi.Location = new Point(158, 35);
            txtMenüEkleAdi.Name = "txtMenüEkleAdi";
            txtMenüEkleAdi.Size = new Size(148, 27);
            txtMenüEkleAdi.TabIndex = 6;
            // 
            // MenüEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 204);
            Controls.Add(nmrMenüEkle);
            Controls.Add(btnMenüEkle);
            Controls.Add(lblFiyat);
            Controls.Add(lblMenüEkle);
            Controls.Add(txtMenüEkleAdi);
            Name = "MenüEkleme";
            Text = "MenüEkleme";
            ((System.ComponentModel.ISupportInitialize)nmrMenüEkle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmrMenüEkle;
        private Button btnMenüEkle;
        private Label lblFiyat;
        private Label lblMenüEkle;
        private TextBox txtMenüEkleAdi;
    }
}