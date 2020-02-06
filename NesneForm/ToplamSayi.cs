using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneForm
{
    class ToplamSayi
    {
        private static ToplamSayi _toplamSayi; //yönetilecek nesne
        private ToplamSayi() //constructer i olan ama dışarıdan erişilemeyen nesne
        { }
        public static ToplamSayi getInstance() //singleton örneğini oluşruracak  metod, oluşturulmuş varsa onu döndür yoksa oluştur öyle döndür
        {
            if (_toplamSayi == null)
            {
                _toplamSayi = new ToplamSayi();
            }
            return _toplamSayi;
        }
        public void Hesapla(int seans1,int seans2,int seans3)
        {
            int sonuc = seans1 + seans2 + seans3;
            MessageBox.Show(sonuc.ToString());
        }
        
    }
 
}
    