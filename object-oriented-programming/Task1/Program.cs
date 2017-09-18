using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 3 cars.
            Car car1 = new Car();
            Car car2 = new Car("Ferrari", 120.2);
            Car car3 = new Car("Mercedes", 0, "Yellow");

            Console.WriteLine(car3.ToString());

            car1.Speed = -81.0;
            car2.Accelerate(43.6);
            car3.Decelerate(10.0);
            
            car1.ShowInfo();
            car2.ShowInfo();
            car3.ShowInfo();

            
            car3.Accelerate();
            car3.ShowInfo();



            Console.ReadKey();
        }
    }


}
