using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEBurgerHouse.Class
{
    public class ExtraMalzeme
    {
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
