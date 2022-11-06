using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Buyer : IObserver
    {
        private IObservable product;
        public Buyer(IObservable obj)
        {
            product = obj;
            obj.AddObserver(this);
        }
        public void Update(double megabites)
        {
            Console.WriteLine("Enter price:");
            int price = Convert.ToInt32(Console.ReadLine());
            if (price < megabites)
            {
                Console.WriteLine($"Підключено пакет на місяць 200 Мб за 7 грн");
                Console.WriteLine("Введіть тривалість дзвінка в хвилинах: ");
                double minutes = Convert.ToDouble(Console.ReadLine());
                if (price < minutes * 0.6)
                {
                    Console.WriteLine($"Недостатньо коштів для здійснення дзвінка");
                }
            }
            else
            {
                Console.WriteLine($"Підключено пакет на 145 грн, де надається 10240 Мб та 200 хв");

            }
        }
    }
}
