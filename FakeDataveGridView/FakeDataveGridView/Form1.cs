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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string isim = FakeData.NameData.GetFirstName();
            //string soyisim = FakeData.NameData.GetSurname();
            //MessageBox.Show(isim + " " + soyisim,"Fake Data inceleme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            database db = new database();
            List<musteri> musteriListele = db.musteriListele();

            dgwMusteriListe.DataSource = musteriListele;


        }

        private void dgwMusteriListe_DoubleClick(object sender, EventArgs e)
        {
            int musteriID = (int)dgwMusteriListe[0, dgwMusteriListe.CurrentCell.RowIndex].Value;

            database db = new database();
            musteri bulunanMusteri = db.musteriListele().FindAll(i => i.id == musteriID).FirstOrDefault();
            popupMesaj popup = new popupMesaj(bulunanMusteri);
            popup.ShowDialog();
        }
    }
}
