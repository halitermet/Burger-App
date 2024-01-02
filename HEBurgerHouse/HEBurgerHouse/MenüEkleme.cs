using HEBurgerHouse.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEBurgerHouse
{
    public partial class MenüEkleme : Form
    {
        public MenüEkleme()
        {
            InitializeComponent();
        }
        private void btnMenüEkle_Click(object sender, EventArgs e)
        {
            Menuu menu = new Menuu();
            menu.Adi = txtMenüEkleAdi.Text;
            menu.Fiyat =(int) nmrMenüEkle.Value;
            SiparişEkleme.menus.Add(menu);
            MessageBox.Show("Menü Başarıya Eklenmiştir.");
            }
    }
}
