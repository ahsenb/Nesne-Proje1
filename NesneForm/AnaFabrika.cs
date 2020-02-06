using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NesneForm
{
    public abstract class Eklemek
    {
        public abstract void Ek(string message);

    }
    public class Yonetici : Eklemek
    {
        public override void Ek(string message)
        {
            MessageBox.Show("Admin ile eklendi");//admin
        }
    }
    public class Yonetici1 : Eklemek
    {
        public override void Ek(string message)
        {
            MessageBox.Show("Admin1 ile eklendi");
        }
    }
    public abstract class Kaydetmek
    {
        public abstract void Kaydet(string data);

    }
    public class Yonetici2 : Kaydetmek
    {
        public override void Kaydet(string data)
        {
            MessageBox.Show("Admin ile kaydedildi");//admin

        }
    }
    public class Yonetici3 : Kaydetmek
    {
        public override void Kaydet(string data)
        {
            MessageBox.Show("Admin1 ile kaydedildi");

        }
    }
    public abstract class AnaFabrika//fabrikaların artacagını gösterir
    {
        public abstract Eklemek CreateEkle();
        public abstract Kaydetmek CreateKaydetmek();
    }
    public class Fabrika1 : AnaFabrika
    {
        public override Eklemek CreateEkle()
        {
            return new Yonetici();
        }

        public override Kaydetmek CreateKaydetmek()
        {
            return new Yonetici3();
        }
    }
    public class Fabrika2 : AnaFabrika
    {
        public override Eklemek CreateEkle()
        {
            return new Yonetici1();
        }

        public override Kaydetmek CreateKaydetmek()
        {
            return new Yonetici3();
        }
    }
    public class FilmYoneticisi
    {
        private AnaFabrika _anaFabrika;

        private Eklemek _eklemek;
        private Kaydetmek _kaydetmek;
        public FilmYoneticisi(AnaFabrika anaFabrika)
        {
            _anaFabrika = anaFabrika;
            _eklemek = _anaFabrika.CreateEkle();
            _kaydetmek = _anaFabrika.CreateKaydetmek();
        }
        public void GetAll()//Film yöneticisinin kullanacağı fabrikayı belirlemiş olduk
        {
            _eklemek.Ek("Eklendi");
            _kaydetmek.Kaydet("data");
            
        }
    }
    //factory deseni
    public class BiletFabrika : IBiletFabrika
    {
        public IBilet CreateBilet()
        {
            return new YoneticiBilet();
        }
    }
    public class BiletFabrika1 : IBiletFabrika
    {
        public IBilet CreateBilet()
        {
            return new Yonetici1Bilet();
        }
    }
    public interface IBiletFabrika
    {
        IBilet CreateBilet();
    }
    public interface IBilet
    {
        void Bil();
    }
    public class YoneticiBilet : IBilet
    {
        public void Bil()
        {
            MessageBox.Show("Bilet admin tarafından oluşturuldu");
        }
    }
    public class Yonetici1Bilet : IBilet
    {
        public void Bil()
        {
           MessageBox.Show("Bilet Admin  tarafından oluşturuldu");
        }
    }
    public class Musteri
    {
        private IBiletFabrika _biletFabrika;
        public Musteri(IBiletFabrika biletFabrika)
        {
            _biletFabrika = biletFabrika;
        }
        public void Save()
        {
            MessageBox.Show("Bilet Oluşturuldu");
            IBilet bilet = _biletFabrika.CreateBilet();
            bilet.Bil();
        }
    }
}
