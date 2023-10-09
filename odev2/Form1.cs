using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kulanici_adi;
            kulanici_adi = textBox1.Text;
            if(kulanici_adi == "miliegitim@meb.k12.tr")
            {
            MessageBox.Show("kullanıcı sisteme kayıtlıdır.");
            }
            else
            {
            MessageBox.Show("kullanıcı adınız yanlıştır.");
            }
        }
    }
}
