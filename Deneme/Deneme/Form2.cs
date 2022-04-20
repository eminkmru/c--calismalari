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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yeniKullaniciEkleme = urunEkleme(new Kullanici()
            {
                id = Guid.NewGuid(),
                Isim = txtIsim.Text,
                Soyisim = txtSoyisim.Text,
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text
            });

            ekranTemizle();
        }

        private int urunEkleme(Kullanici data)
        {

            SanalDatabase.KullaniciListe.Add(data);
            MessageBox.Show("Kullanici Ekleme Başarılı.", "Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        private void ekranTemizle()
        {
            txtIsim.Text = String.Empty;
            txtSoyisim.Text = String.Empty;
            txtTelefon.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }
    }
}
