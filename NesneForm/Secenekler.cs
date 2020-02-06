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
    public partial class Secenekler : Form
    {
        public Secenekler()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) //Eğer checkbox1 seçildiyse
            {
                ProductManager productManager;
                DegisiklikOperation degisiklikOperation;
                if (label2.Text == "0")
                {
                    degisiklikOperation = new DegisiklikOperation(new IndirimStrategy());
                    degisiklikOperation.MakeDegisiklik();
                    var yoneticiObserver = new YoneticiObserver();
                    productManager = new ProductManager();
                    productManager.Attach(new YoneticiObserver());
                    productManager.UpdatePrice();
                }
                else 
                {
                    degisiklikOperation = new DegisiklikOperation(new SabitStrategy());
                    degisiklikOperation.MakeDegisiklik();
                }
                
                FilmEkle fe = new FilmEkle();
                fe.Show();
                this.Hide();
            }else if(checkBox2.Checked==true)//checkbox2 seçildiyse
            {
                ToplamIzleyiciSayisi tıs = new ToplamIzleyiciSayisi();
                tıs.Show();
                this.Hide();
            }else if(checkBox3.Checked==true)
            {

            }
            else
            {
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ToplamIzleyiciSayisi tıs = new ToplamIzleyiciSayisi();
            tıs.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToString());
        }

        private void Secenekler_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";
            comboBox1.Items.Add("Biletlere %25 indirim uygula");
            comboBox1.Items.Add("Sabit Fiyat");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedIndex.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri(new BiletFabrika1());
            musteri.Save();
            Console.ReadLine();
        }
    }
}
