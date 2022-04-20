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
    public partial class KayitGoruntule : Form
    {
        public KayitGoruntule()
        {
            InitializeComponent();
            ekranListele();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ekranListele()
        {
            listBox1.DataSource = SanalDatabase.KullaniciListe;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            CiftTiklamaKayitGoruntule ciftTiklamaKayitGoruntule = new CiftTiklamaKayitGoruntule();
            ciftTiklamaKayitGoruntule.ShowDialog();
            ListBox lbox = (ListBox)sender;
            ((TextBox) ciftTiklamaKayitGoruntule.Controls["txtIsimm"]).Text = lbox.SelectedItem.ToString();
        }
    }
}
