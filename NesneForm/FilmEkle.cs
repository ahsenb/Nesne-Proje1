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
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//geri butonuna basıldığında
        {
            Secenekler s = new Secenekler();
            s.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//ileri butonuna basıldığında
        {
            Bitis b = new Bitis();
            b.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToString());
        }

        private void FilmEkle_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilmYoneticisi filmYoneticisi = new FilmYoneticisi(new Fabrika2());
            filmYoneticisi.GetAll();
            Console.ReadLine();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
