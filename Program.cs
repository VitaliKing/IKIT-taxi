using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKIT_taxi;

namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxi> cars = new List<Taxi>();
            Taxi car1 = new Taxi("Волга", 4, 15, 10);
            Taxi car2 = new Taxi("Микроавтобус", 8, 40, 15);
            Taxi car3 = new Taxi("Ока", 2, 24, 8);
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            Console.Write("Введите расстояние: ");
            double Distance = double.Parse(Console.ReadLine());
            Console.Write("Введите количество пассажиров: ");
            int Pass = int.Parse(Console.ReadLine());
            foreach (var car in cars)
            {
                if (car.InspecOrder(Distance, Pass))
                {
                    Console.WriteLine(car.Name);
                    cars.Remove(car);
                    cars.Add(car);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
