using System;
using System.Windows.Forms;

namespace NesneForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)//müşteri butonuna basıldığında
        {
            MUSTERIGIRISI mg = new MUSTERIGIRISI();
            mg.Show();
            Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//saat ayarı
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)//gün ayarı
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";
        }

        private void button2_Click(object sender, EventArgs e)//Yönetici kısmına geçme
        {
            YoneticiGirisi yg = new YoneticiGirisi();
            yg.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}

