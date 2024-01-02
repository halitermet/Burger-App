using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEBurgerHouse.Class
{
   public class SiparisMenu
    {
        public Menuu Menu { get; set; }
        public int Adet { get; set; }
        public double ToplamTutar { get; set; }
        public bool OnaylandiMi {  get; set; }  

        public List<ExtraMalzeme>extraMalzemes= new List<ExtraMalzeme>();
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Adet + " x " + Menu.Adi + " Menü " + Menu.sizeBoy + " menü Fiyatı " + ToplamTutar.ToString());

            sb.AppendLine(" Ekstra Malzemeler: ");

            foreach (var item in extraMalzemes)

                sb.AppendLine(item.Adi);

            return sb.ToString();

        }

    }
}
