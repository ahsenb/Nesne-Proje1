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
    public partial class ÖdemeYap : Form
    {
        public ÖdemeYap()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToString());
        }

        private void TamÖdeme_Load(object sender, EventArgs e)
        {
            textBox2.MaxLength = 16;
            textBox3.MaxLength = 3;
            label5.Visible = false;//strategy için uygulanan 1,0 label ini gizleme
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";
            comboBox1.Items.Add("Banka Kartı");
            comboBox1.Items.Add("Kredi Kartı");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = comboBox1.SelectedIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //strategy deseni çağırma
            PaymentOperation paymentOperation;
            if (label5.Text == "0")
            {
                paymentOperation = new PaymentOperation(new BankaKartiStrategy());
                paymentOperation.MakePayment();
            }
            else if (label5.Text == "1")
            {
                paymentOperation = new PaymentOperation(new KrediKartiStrategy());
                paymentOperation.MakePayment();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız Oldu");
            }
            Bitis _bitis = new Bitis();
            _bitis.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox1.SelectedIndex.ToString();
        }

        private void button2_Click(object sender, EventArgs e)//geri butonuna basıldığında
        {
            MusteriBiletSecimi mbs = new MusteriBiletSecimi();
            mbs.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
