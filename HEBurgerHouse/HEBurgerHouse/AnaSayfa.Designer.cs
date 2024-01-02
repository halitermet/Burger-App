namespace HEBurgerHouse
{
    partial class AnaSayfa
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            siparisYönetimiToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            siparisBilgileriToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menüEklemeToolStripMenuItem = new ToolStripMenuItem();
            extraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparisYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1257, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparisYönetimiToolStripMenuItem
            // 
            siparisYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem, siparisBilgileriToolStripMenuItem });
            siparisYönetimiToolStripMenuItem.Name = "siparisYönetimiToolStripMenuItem";
            siparisYönetimiToolStripMenuItem.Size = new Size(129, 24);
            siparisYönetimiToolStripMenuItem.Text = "Siparis Yönetimi";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(191, 26);
            siparişOluşturToolStripMenuItem.Text = "Siparis Ekleme";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // siparisBilgileriToolStripMenuItem
            // 
            siparisBilgileriToolStripMenuItem.Name = "siparisBilgileriToolStripMenuItem";
            siparisBilgileriToolStripMenuItem.Size = new Size(191, 26);
            siparisBilgileriToolStripMenuItem.Text = "Siparis Bilgileri";
            siparisBilgileriToolStripMenuItem.Click += siparisBilgileriToolStripMenuItem_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menüEklemeToolStripMenuItem, extraMalzemeEkleToolStripMenuItem });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(116, 24);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menüEklemeToolStripMenuItem
            // 
            menüEklemeToolStripMenuItem.Name = "menüEklemeToolStripMenuItem";
            menüEklemeToolStripMenuItem.Size = new Size(221, 26);
            menüEklemeToolStripMenuItem.Text = "Menü Ekleme";
            menüEklemeToolStripMenuItem.Click += menüEklemeToolStripMenuItem_Click;
            // 
            // extraMalzemeEkleToolStripMenuItem
            // 
            extraMalzemeEkleToolStripMenuItem.Name = "extraMalzemeEkleToolStripMenuItem";
            extraMalzemeEkleToolStripMenuItem.Size = new Size(221, 26);
            extraMalzemeEkleToolStripMenuItem.Text = "Extra Malzeme Ekle";
            extraMalzemeEkleToolStripMenuItem.Click += extraMalzemeEkleToolStripMenuItem_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1257, 953);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnaSayfa";
            Text = "AnaSayfa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparisYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparisBilgileriToolStripMenuItem;
        private ToolStripMenuItem menüEklemeToolStripMenuItem;
        private ToolStripMenuItem extraMalzemeEkleToolStripMenuItem;
    }
}