using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kayit ff = new Kayit();
            ff.ShowDialog();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            KayitGoruntule kayitGoruntule = new KayitGoruntule();
            kayitGoruntule.ShowDialog();
        }
    }
}
