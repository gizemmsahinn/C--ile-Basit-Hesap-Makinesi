using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizlenecekmi;
        private int _ilkSayi;


        public Form1()
        {
            InitializeComponent();
        }

        private void ekranLabel_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text == "0") ;
            ekranLabel.Text = " ";
        }
        private void Sayi1Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "1";

        }

        private void sayi2Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "2";
        }

        private void sayi3Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "3";
        }

        private void sayi4Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "4";
        }

        private void sayi5Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "5";
        }

        private void sayi6Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "6";
        }

        private void sayi7Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "7";
        }

        private void sayi8Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "8";
        }

        private void sayi9Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "9";
        }

        private void sayi0Buton_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi) ekranLabel.Text = "";
            {
                _ekrantemizlenecekmi = false;
            }
            ekranLabel.Text += "0";
        }

        private void clearButon_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text == "0") ;
            ekranLabel.Text = " ";
        }

        private void toplamButon_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void esittirButon_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuç;

            switch (_islem)
            {
                case '+':
                    sonuç = _ilkSayi + ikinciSayi;
                    break;

                case '-':
                    sonuç = _ilkSayi - ikinciSayi;
                    break;

                case '*':
                    sonuç = _ilkSayi * ikinciSayi;
                    break;

                case '/':
                    sonuç = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuç = 0;
                    break;

            }

            ekranLabel.Text = Convert.ToString(sonuç);

        }

        private void cıkarmaButon_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpimButon_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void bolumButon_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }
    }
}
