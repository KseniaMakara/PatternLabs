using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Product : IObservable
    {
        private List<IObserver> observers;
        private double megabites;

        public Product(double mb)
        {
            megabites = mb;
            observers = new List<IObserver>();
        }
        public void ChangeMegaBites(double mb)
        {
            megabites = mb;
            Notify();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        public void Notify()
        {
            foreach (IObserver o in observers.ToList())
            {
                o.Update(megabites);
            }
        }
    }
}
