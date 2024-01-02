using HEBurgerHouse.Class;
using HEBurgerHouse.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HEBurgerHouse
{
    public partial class SiparişEkleme : Form
    {
        SiparisMenu siparis;
        public static List<SiparisMenu> Siparisler = new List<SiparisMenu>();
        double toplamTutar = 0;
        public SiparişEkleme()
        {
            InitializeComponent();

            foreach (var item in Siparisler)
                toplamTutar += item.ToplamTutar;

            lblToplamTutar.Text = toplamTutar.ToString();
            cmbmenüSec.Items.AddRange(menus.ToArray());

            clbxExtra.Items.AddRange(ekstralar.ToArray());
        }
        public static List<ExtraMalzeme> ekstralar = new List<ExtraMalzeme>()
        {
            new ExtraMalzeme() { Adi ="Acı Sos",Fiyat=3 },
            new ExtraMalzeme() { Adi ="Ketçap",Fiyat=4 },
            new ExtraMalzeme() { Adi ="Range Sos",Fiyat=4 },
            new ExtraMalzeme() { Adi ="Bufalo Sos",Fiyat=4 },
        };
        public static List<Menuu> menus = new List<Menuu>()
        {
              new Menuu() {Adi="King Daisy Burger",Fiyat=100},
              new Menuu() {Adi="Halit Special Burger",Fiyat=120},
              new Menuu() {Adi="Classic Burger",Fiyat=130},
              new Menuu() {Adi="Xlarge Burger",Fiyat=140},
              new Menuu() {Adi="Chess Burger",Fiyat=150},
              new Menuu() {Adi="Kids Burger",Fiyat=160}
        };
        private void btnSiparisMenüyeEkle_Click_1(object sender, EventArgs e)
        {
            siparis = new SiparisMenu();
            siparis.Menu = (Menuu)cmbmenüSec.SelectedItem;
            siparis.Adet = (int)nmradet.Value;
            siparis.ToplamTutar += (siparis.Adet * ((Menuu)cmbmenüSec.SelectedItem).Fiyat);

            foreach (var item in ekstralar)
            {
                clbxExtra.Controls.Add(new CheckBox() { Text = item.Adi });
            }

            if (rbtnbüyük.Checked)
            {
                siparis.Menu.sizeBoy = SizeBoy.Büyük;
                siparis.ToplamTutar *= 1.5d;
            }
            else if (rbtnorta.Checked)
            {
                siparis.Menu.sizeBoy = SizeBoy.Orta;
                siparis.ToplamTutar *= 1.25d;
            }
            else if (rbtnkücük.Checked)
            {
                siparis.Menu.sizeBoy = SizeBoy.Küçük;
            }
            else
                MessageBox.Show("Lütfen Boyut Seçiniz !!");


            for (int i = 0; i < clbxExtra.Items.Count; i++)
            {
                if (clbxExtra.GetItemChecked(i) == true)
                {
                    siparis.extraMalzemes.Add((ExtraMalzeme)clbxExtra.Items[i]);
                }
            }

            foreach (var item in siparis.extraMalzemes)
            {
                siparis.ToplamTutar += item.Fiyat;
            }

            toplamTutar += siparis.ToplamTutar;


            lblToplamTutar.Text = toplamTutar.ToString();
            Siparisler.Add(siparis);
            listSiparis.Items.Add(siparis);
        }

        private void btnSiparisTamamla_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Siparişi Onaylıyor musunuz Toplam Tutar:{lblToplamTutar.Text} ", "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listSiparis.Items.Clear();
                foreach (var item in Siparisler)
                {
                    item.OnaylandiMi = true;
                }
            }
            else
            {
                MessageBox.Show("Sipariş onaylanmadı");
            }

        }
    }
}

