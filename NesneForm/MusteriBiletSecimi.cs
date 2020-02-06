using System;
using System.Windows.Forms;

namespace NesneForm
{
    public partial class MusteriBiletSecimi : Form
    {
        public MusteriBiletSecimi()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToString());
        }
        private void MusteriBiletSecimi_Load(object sender, EventArgs e)
        {
            label9.Visible = false;
            label10.Visible = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";
            comboBox1.Items.Add("İncir Reçeli");//Film ekleme
            comboBox1.Items.Add("Yol Arkadaşım");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button8_Click(object sender, EventArgs e)//Ödeme butonuna basıldığında
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Seans1 seçildi!");
                ÖdemeYap to = new ÖdemeYap();
                to.Show();
                this.Hide();
            }
            else if (checkBox2.Checked == true)
            {
                MessageBox.Show("Seans2 seçildi!");
                ÖdemeYap to = new ÖdemeYap();
                to.Show();
                this.Hide();
            }
            else if (checkBox3.Checked)
            {
                MessageBox.Show("Seans3 seçildi");
                ÖdemeYap to = new ÖdemeYap();
                to.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seans seçilmediği için işlem başarısız oldu");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)//Mesaj butonuna basıldığında
        {
            var musteriObserver = new MusteriObserver();
            ProductManager productManager = new ProductManager();
            productManager.Attach(new MusteriObserver());
            productManager.UpdatePrice();
        }

        private void button10_Click(object sender, EventArgs e)//Geri butonuna basıldığında
        {
            MUSTERIGIRISI mg = new MUSTERIGIRISI();
            mg.Show();
            this.Hide();
        }
        decimal ucret;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Increment = 1;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 30;
            label9.Text = Convert.ToString(numericUpDown1.Value);
            Tam tam = new Tam(new Ogrenci(new Bilet()));
            label11.Text = tam.aciklama();
            ucret = tam.ucret();
            label11.Text = Convert.ToString(ucret * numericUpDown1.Value) + "TL";
        }



        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Increment = 1;
            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 30;
            label10.Text = Convert.ToString(numericUpDown3.Value);
            Tam tam = new Tam(new Tam(new Bilet()));
            label12.Text = tam.aciklama();
            ucret = tam.ucret();
            label12.Text = Convert.ToString(ucret * numericUpDown3.Value) + "TL";
        }
        
  
        private void label9_Click(object sender, EventArgs e)
        {  
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = numericUpDown3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  toplam;
            toplam = Convert.ToInt32(label11.Text) +Convert.ToInt32(label12.Text);
            MessageBox.Show(toplam.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
