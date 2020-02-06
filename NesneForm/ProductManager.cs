using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NesneForm
{
    abstract class Observer
    {
        public abstract void Update();

    }
    class MusteriObserver : Observer
    {
        public override void Update()
        {
            MessageBox.Show("Bilet fiyatlarında indirim oldu!");
        }

    }
    class YoneticiObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Müşteri bilgilendirildi : Bilet fiyatları düştü!");
        }

    }
    class ProductManager
    {
        List<Observer> _observers = new List<Observer>();
        public void UpdatePrice()
        {
            Console.WriteLine("Bilet fiyatlarında indirim oldu!");
            Notify();
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
