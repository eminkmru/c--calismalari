using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeDataveGridView
{
    public partial class popupMesaj : Form
    {
        musteri musteriData;
        public popupMesaj(musteri data)
        {
            InitializeComponent();
            musteriData = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void popupMesaj_Load(object sender, EventArgs e)
        {
            txtIsim.Text = musteriData.isim;
            txtSoyisim.Text = musteriData.soyisim;
            txtTamIsim.Text = musteriData.tamAdi;
            txtEmail.Text = musteriData.emailAdres;
            txtTelefon.Text = musteriData.telefonNumarasi;
            txtAdres.Text = musteriData.adres;
        }
    }
}
