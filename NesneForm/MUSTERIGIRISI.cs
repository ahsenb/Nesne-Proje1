using System;
using System.Windows.Forms;

namespace NesneForm
{
    public partial class MUSTERIGIRISI : Form
    {
        public MUSTERIGIRISI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToString());
        }

        private void MUSTERIGIRISI_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 5;
            progressBar1.Minimum = 0;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";
        }
        
        private void button1_Click(object sender, EventArgs e)//Giriş butonuna basıldığında
        {
            if ((textBox1.Text == "zDonmez")  && (textBox2.Text == "12345"))
            {
                MusteriBiletSecimi mbs = new MusteriBiletSecimi();
                mbs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!!");
            }
        }

        private void MUSTERIGIRISI_FormClosing(object sender, FormClosingEventArgs e)
        {
                foreach (Form item in Application.OpenForms)
                {
                    if (item is Form1)
                    {
                        item.Show();
                        break;
                    }
                }
            
        }

        private void button2_Click(object sender, EventArgs e)//Geri tuşuna basıldığında
        {
            Form1 _anasayfa = new Form1();
            _anasayfa.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 5;
            progressBar1.Step = 8;
            progressBar1.PerformStep();
        }

        
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
          
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
