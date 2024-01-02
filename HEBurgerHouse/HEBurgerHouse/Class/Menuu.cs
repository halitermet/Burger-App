using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEBurgerHouse.Enum;
using SizeBoy = HEBurgerHouse.Enum.SizeBoy;

namespace HEBurgerHouse.Class
{
    public class Menuu
    {
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public SizeBoy sizeBoy { get; set; }

        public override string ToString()
        {
            return Adi;
        }

    }
}
