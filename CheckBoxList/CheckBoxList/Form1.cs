using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedBoxListDoldurV1();
        }

        private void checkedBoxListDoldurV1()
        {
            foreach (var item in Database.UrunTablo)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
            {
                Urun secilenUrun = checkedListBox.Items[e.Index] as Urun;
                txtUrunAdi.Text = secilenUrun.UrunAdi;
                txtKategori.Text = secilenUrun.UrunKategori;
                txtStok.Text = secilenUrun.StokAdedi.ToString();
                txtYazar.Text = secilenUrun.Yazar;
                rtxtAciklama.Text=secilenUrun.Aciklama;

            }

            
        }
    }
}
