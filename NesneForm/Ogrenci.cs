using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneForm
{
    //dekorator kullanımı
    public interface ClasTipi
    {
        decimal ucret();
        string aciklama();
    }

    public class Bilet : ClasTipi
    {
        public decimal ucret()
        {
            return 8.00m;
        }
        public string aciklama()
        {
            return "bileti";
        }

    }
    class Ogrenci:ClasTipi
    {
        ClasTipi _bilet;

        public Ogrenci(ClasTipi bilet)
        {
           _bilet = bilet;
        }

        public decimal ucret()
        {
            return _bilet.ucret() - 5.00m;
        }

        public string aciklama()
        {
            return "öğrenci " + _bilet.aciklama();
        }
    }
    public class Tam : ClasTipi

    {
        ClasTipi _bilet;
        public Tam(ClasTipi bilet)
        {
            _bilet = bilet;
        }

        public decimal ucret()
        {
            return _bilet.ucret();
        }

        public string aciklama()
        {
            return "tam " + _bilet.aciklama();
        }

    }
}
