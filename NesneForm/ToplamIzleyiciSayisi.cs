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
    public partial class ToplamIzleyiciSayisi : Form
    {
        public ToplamIzleyiciSayisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitis b = new Bitis();
            b.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Secenekler s = new Secenekler();
            s.Show();
            this.Hide();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            var toplamIzleyiciSayisi = ToplamSayi.getInstance();

            int seans1, seans2, seans3;
            seans1 = Convert.ToInt32(textBox1.Text);
            seans2 = Convert.ToInt32(textBox2.Text);
            seans3 = Convert.ToInt32(textBox3.Text);
            toplamIzleyiciSayisi.Hesapla(seans1,seans2,seans3);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToplamIzleyiciSayisi_Load(object sender, EventArgs e)
        {

        }
    }
}
