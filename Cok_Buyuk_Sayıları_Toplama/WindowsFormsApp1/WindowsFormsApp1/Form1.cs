using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sayi1, sayi2;
            sayi1 = txt_SayiBir.Text;
            sayi2 = txt_SayiIki.Text;
            string sonuc = hespla(sayi1, sayi2);
            textBox1.Text = sonuc;
        }

        private string hespla(string str1, string str2)
        {
            int say1, say2;
            say1 = str1.Length;
            say2 = str2.Length;
            int elde = 0;
            string[] newNumber = new string[say1];
            if (say1 > say2)
            {
                str2 = str2.PadLeft(str1.Length, '0');
                for (int i = say1 - 1; i + 2 > 1; i--)
                {
                    int a = (str1[i] - '0');
                    int b = (str2[i] - '0');
                    int toplam = a + b;

                    if (elde == 1)
                    {
                        toplam = toplam + 1;
                    }
                    elde = 0;

                    if (toplam > 9)
                    {
                        elde = 1;
                        newNumber[i] = Convert.ToString(toplam - 10);
                    }
                    else
                    {
                        newNumber[i] = Convert.ToString(toplam);
                    }

                }
            }
            else if (say1 == say2)
            {
                say1 = say1 + 1;
                say2 = say2 + 1;
                str2 = str2.PadLeft(str1.Length, '0');
                str1 = str1.PadLeft(str2.Length, '0');
                for (int i = say1 - 1; i + 2 > 1; i--)
                {
                    int a = (str1[i - 1] - '0');
                    int b = (str2[i - 1] - '0');
                    int toplam = a + b;

                    if (elde == 1)
                    {
                        toplam = toplam + 1;
                    }
                    elde = 0;

                    if (toplam > 9)
                    {
                        elde = 1;
                        newNumber[i] = Convert.ToString(toplam - 10);
                    }
                    else
                    {
                        newNumber[i] = Convert.ToString(toplam);
                    }

                }
            }
            else {
                str1 = str1.PadLeft(str2.Length, '0');
                for (int i = say2 - 1; i + 2 > 1; i--)
                {
                    int a = (str1[i] - '0');
                    int b = (str2[i] - '0');
                    int toplam = a + b;

                    if (elde == 1)
                    {
                        toplam = toplam + 1;
                    }
                    elde = 0;

                    if (toplam > 9)
                    {
                        elde = 1;
                        newNumber[i] = Convert.ToString(toplam - 10);
                    }
                    else
                    {
                        newNumber[i] = Convert.ToString(toplam);
                    }

                }
            }
            string yeni = "";
            foreach (var items in newNumber)
            {
                yeni = yeni + items;
            }


            return yeni;
        }
    }
}
