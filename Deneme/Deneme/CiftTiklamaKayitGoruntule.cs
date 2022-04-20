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
    public partial class CiftTiklamaKayitGoruntule : Form
    {
        public CiftTiklamaKayitGoruntule()
        {
            InitializeComponent();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIsimm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
