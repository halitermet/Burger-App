using HEBurgerHouse.Class;
using Microsoft.VisualBasic;
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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGoster(Form gosterilecekForm)
        {
            gosterilecekForm.StartPosition = 0;

            if (!MdiChildren.Contains(gosterilecekForm))

                gosterilecekForm.MdiParent = this;
            foreach (Form altForm in this.MdiChildren)
            {

                if (gosterilecekForm.Text == altForm.Text)
                {
                    altForm.Show();
                }
                else
                {
                    altForm.Close();
                }
            }
        }
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparişEkleme());
        }
        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparişBilgileri());
        }

        private void menüEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new MenüEkleme());
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new ExtraMalzemeEkleme());
        }

    }
}
