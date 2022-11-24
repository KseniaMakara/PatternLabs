using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1

{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }

  
    public class Subject : ISubject
    {
        
        public double State { get; set; } = -0;

      
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

      
        public void Phonecall()
        {

            Console.WriteLine("\n Enter your number: ");
            string number = Console.ReadLine();
            Console.WriteLine("\n Enter minutes: ");
            double minutes = Convert.ToDouble( Console.ReadLine());

            this.State = new Random().Next(0, 300);
            Console.WriteLine($"Current account: {this.State}");
            double packageMin = 200;
            double amountMinutes = 1.7;
            double result = 0;
            if (this.State >= 145)
            {
                Console.WriteLine("Підключено пакет на місяць 145 грн за 10240 Мб та 200 хв");

                this.State -= 145;
                result = packageMin - amountMinutes* minutes;
                if(result >= 0)
                {
                    Console.WriteLine($"Лишилось {result} хв та {this.State} грн "); ;
                }
                else
                {
                    Console.WriteLine($"Хвилин лишилось 0, Грошей лишилось {this.State} ");

                }
            }
            else if(this.State < 145 )
            {
                Console.WriteLine("Підключено пакет на місяць 200 Мб за 7 грн та дзвінки по 0,60 грн/хв");
                minutes *= 0.6;
                this.State -= minutes;
                if (this.State >= 0)
                {
                    Console.WriteLine($"Лишилось {this.State} грн, та {this.State/0.6} хв на дзвінок "); ;
                }
                else
                {
                    Console.WriteLine($"Грошей лишилось 0, ми повинні перервати дзвінок");
                }
            }
           
            this.Notify();
        }
       


    }

    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.Phonecall();
            subject.Phonecall();

            subject.Detach(observerB);

            subject.Phonecall();
        }
    }
}