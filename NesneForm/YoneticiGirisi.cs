using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneForm
{
    public partial class YoneticiGirisi : Form
    {
        public YoneticiGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Giriş butonuna basıldığında
        {
            if ( ((textBox1.Text=="admin") ||(textBox1.Text=="Admin"))&&(textBox2.Text == "admin"))
            {

                Secenekler s = new Secenekler();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya kullanıcı adı hatalı tekrar dene");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)//Geri  butonuna basıldığında
        {
            Form1 _anasayfa = new Form1();
            _anasayfa.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToString());
        }

        private void YoneticiGirisi_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
