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
    public partial class SiparişBilgileri : Form
    {
        public SiparişBilgileri()
        {
            InitializeComponent();
            foreach (var item in SiparişEkleme.Siparisler)
            {
                if (item.OnaylandiMi)
                {
                    lstBxSiparisListesi.Items.Add(item);
                }

            }
        }
        private void SiparişBilgileri_Load(object sender, EventArgs e)
        {
            lblCiro.Text = SiparişEkleme.Siparisler.Where(s => s.OnaylandiMi).Sum(s => s.ToplamTutar).ToString();

            lblTplmsprsSys.Text = SiparişEkleme.Siparisler.Count.ToString();

            double extraMalzemeToplamı = 0;
            lblStlnUrunAdedi.Text = SiparişEkleme.Siparisler.Where(s => s.OnaylandiMi).Sum(s => s.Adet).ToString();
            foreach (var item in SiparişEkleme.Siparisler.Where(s => s.OnaylandiMi))
            {
                foreach (var item2 in item.extraMalzemes)
                {
                    extraMalzemeToplamı += item2.Fiyat;
                    lblExtraMlzmGlr.Text = extraMalzemeToplamı.ToString();
                }
            }

        }
    }
}
