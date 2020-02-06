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
    public partial class Bitis : Form
    {
        public Bitis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tekrardan işlem yapmak isterse diye ana sayfaya yönlendirme
            Form1 _anasayfa = new Form1();
            _anasayfa.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Bitis_Load(object sender, EventArgs e)
        {

        }
    }
}
