namespace HEBurgerHouse
{
    partial class SiparişEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparişEkleme));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbtnkücük = new RadioButton();
            rbtnorta = new RadioButton();
            rbtnbüyük = new RadioButton();
            nmradet = new NumericUpDown();
            clbxExtra = new CheckedListBox();
            listSiparis = new ListBox();
            btnSiparisTamamla = new Button();
            btnSiparisMenüyeEkle = new Button();
            MenüSeçin = new Label();
            cmbmenüSec = new ComboBox();
            pictureBox1 = new PictureBox();
            lblTutar = new Label();
            lblToplamTutar = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmradet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(25, 499);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 43;
            label3.Text = "ADET";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(9, 326);
            label2.Name = "label2";
            label2.Size = new Size(277, 23);
            label2.TabIndex = 42;
            label2.Text = "EKSTRA MALZEME SEÇİNİZ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 23);
            label1.TabIndex = 35;
            label1.Text = "BOYUT SEÇİNİZ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnkücük);
            groupBox1.Controls.Add(rbtnorta);
            groupBox1.Controls.Add(rbtnbüyük);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 53);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            // 
            // rbtnkücük
            // 
            rbtnkücük.AutoSize = true;
            rbtnkücük.Location = new Point(6, 26);
            rbtnkücük.Name = "rbtnkücük";
            rbtnkücük.Size = new Size(69, 24);
            rbtnkücük.TabIndex = 14;
            rbtnkücük.TabStop = true;
            rbtnkücük.Text = "Küçük";
            rbtnkücük.UseVisualStyleBackColor = true;
            // 
            // rbtnorta
            // 
            rbtnorta.AutoSize = true;
            rbtnorta.Location = new Point(103, 23);
            rbtnorta.Name = "rbtnorta";
            rbtnorta.Size = new Size(59, 24);
            rbtnorta.TabIndex = 15;
            rbtnorta.TabStop = true;
            rbtnorta.Text = "Orta";
            rbtnorta.UseVisualStyleBackColor = true;
            // 
            // rbtnbüyük
            // 
            rbtnbüyük.AutoSize = true;
            rbtnbüyük.Location = new Point(203, 26);
            rbtnbüyük.Name = "rbtnbüyük";
            rbtnbüyük.Size = new Size(69, 24);
            rbtnbüyük.TabIndex = 16;
            rbtnbüyük.TabStop = true;
            rbtnbüyük.Text = "Büyük";
            rbtnbüyük.UseVisualStyleBackColor = true;
            // 
            // nmradet
            // 
            nmradet.Location = new Point(104, 499);
            nmradet.Name = "nmradet";
            nmradet.Size = new Size(124, 27);
            nmradet.TabIndex = 40;
            // 
            // clbxExtra
            // 
            clbxExtra.FormattingEnabled = true;
            clbxExtra.Location = new Point(14, 349);
            clbxExtra.Name = "clbxExtra";
            clbxExtra.Size = new Size(325, 136);
            clbxExtra.TabIndex = 39;
            // 
            // listSiparis
            // 
            listSiparis.FormattingEnabled = true;
            listSiparis.ItemHeight = 20;
            listSiparis.Location = new Point(349, 15);
            listSiparis.Name = "listSiparis";
            listSiparis.Size = new Size(523, 504);
            listSiparis.TabIndex = 38;
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.Location = new Point(667, 541);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(205, 34);
            btnSiparisTamamla.TabIndex = 37;
            btnSiparisTamamla.Text = "Siparişi Tamamla";
            btnSiparisTamamla.UseVisualStyleBackColor = true;
            btnSiparisTamamla.Click += btnSiparisTamamla_Click_1;
            // 
            // btnSiparisMenüyeEkle
            // 
            btnSiparisMenüyeEkle.Location = new Point(25, 541);
            btnSiparisMenüyeEkle.Name = "btnSiparisMenüyeEkle";
            btnSiparisMenüyeEkle.Size = new Size(208, 35);
            btnSiparisMenüyeEkle.TabIndex = 36;
            btnSiparisMenüyeEkle.Text = "Siparişi Menüye Ekle";
            btnSiparisMenüyeEkle.UseVisualStyleBackColor = true;
            btnSiparisMenüyeEkle.Click += btnSiparisMenüyeEkle_Click_1;
            // 
            // MenüSeçin
            // 
            MenüSeçin.AutoSize = true;
            MenüSeçin.BackColor = Color.WhiteSmoke;
            MenüSeçin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MenüSeçin.ForeColor = SystemColors.ActiveCaptionText;
            MenüSeçin.Location = new Point(14, 181);
            MenüSeçin.Name = "MenüSeçin";
            MenüSeçin.Size = new Size(133, 23);
            MenüSeçin.TabIndex = 34;
            MenüSeçin.Text = "MENÜ SEÇİN";
            // 
            // cmbmenüSec
            // 
            cmbmenüSec.FormattingEnabled = true;
            cmbmenüSec.Location = new Point(14, 207);
            cmbmenüSec.Name = "cmbmenüSec";
            cmbmenüSec.Size = new Size(301, 28);
            cmbmenüSec.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTutar.Location = new Point(349, 546);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(138, 23);
            lblTutar.TabIndex = 44;
            lblTutar.Text = "TOPLAM TUTAR";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(505, 546);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(46, 23);
            lblToplamTutar.TabIndex = 45;
            lblToplamTutar.Text = " 0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(552, 548);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 46;
            label4.Text = "$";
            // 
            // SiparişEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(908, 604);
            Controls.Add(label4);
            Controls.Add(lblToplamTutar);
            Controls.Add(lblTutar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(nmradet);
            Controls.Add(clbxExtra);
            Controls.Add(listSiparis);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(btnSiparisMenüyeEkle);
            Controls.Add(MenüSeçin);
            Controls.Add(cmbmenüSec);
            Controls.Add(pictureBox1);
            Name = "SiparişEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SiparisEkleme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmradet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtnkücük;
        private RadioButton rbtnorta;
        private RadioButton rbtnbüyük;
        private NumericUpDown nmradet;
        private CheckedListBox clbxExtra;
        private ListBox listSiparis;
        private Button btnSiparisTamamla;
        private Button btnSiparisMenüyeEkle;
        private Label MenüSeçin;
        private ComboBox cmbmenüSec;
        private PictureBox pictureBox1;
        private Label lblTutar;
        private Label lblToplamTutar;
        private Label label4;
    }
}