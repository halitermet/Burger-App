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
    public partial class ExtraMalzemeEkleme : Form
    {
        public ExtraMalzemeEkleme()
        {
            InitializeComponent();
        }
        private void btnExtraMalzemeKaydet_Click(object sender, EventArgs e)
        {
            ExtraMalzeme extramalzemess = new ExtraMalzeme();
            extramalzemess.Adi = txtExtraAdi.Text;
            extramalzemess.Fiyat = (int)nmrExtraFiyat.Value;
            SiparişEkleme.ekstralar.Add(extramalzemess);
            MessageBox.Show("Ekstra Malzeme Başarıyla Eklenmiştir.");



        }
    }
}
