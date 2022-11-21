using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности равна:");
            Console.WriteLine(Circle.GetCircleLength(r));
            Console.WriteLine("Площадь круга равна:");
            Console.WriteLine(Circle.GetCircleSquare (r));
            Console.WriteLine("Введите координаты точки");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Circle.CheckCirclePoint(r,x,y));


            Console.ReadKey();


        }
    }
}
