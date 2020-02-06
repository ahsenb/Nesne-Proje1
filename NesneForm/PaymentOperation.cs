using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NesneForm
{
    //müsteri girisi
    interface IPayment
    {
        void MakePayment();
    }
    class BankaKartiStrategy : IPayment
    {
        public void MakePayment()
        {
           MessageBox.Show("Banka kartı ile ödeme yapıldı.");
        }
    }
    class KrediKartiStrategy : IPayment
    {
        public void MakePayment()
        {
            MessageBox.Show("Kredi kartı ile ödeme yapıldı.");
        }
    }

    class PaymentOperation
    {
        private IPayment _odeme;
        public PaymentOperation(IPayment _odeme)
        {
            this._odeme = _odeme;
        }

        public void MakePayment()
        {
            this._odeme.MakePayment();
        }
    }

    //yönetici girisi
    interface IDegisiklik
    {
        void MakeDegisiklik();
    }
    class IndirimStrategy : IDegisiklik
    {
        public void MakeDegisiklik()
        {
           MessageBox.Show("Bilet fiyatlarında indirim yapıldı.");
        }
    }
    class SabitStrategy : IDegisiklik
    {
        public void MakeDegisiklik()
        {
            MessageBox.Show("Fiyatlarda değişiklik olmadı.");
        }
    }

    class DegisiklikOperation
    {
        private IDegisiklik _degisiklik;
        public DegisiklikOperation(IDegisiklik _degisiklik)
        {
            this._degisiklik = _degisiklik;
        }

        public void MakeDegisiklik()
        {
            this._degisiklik.MakeDegisiklik();
        }
    }
}
