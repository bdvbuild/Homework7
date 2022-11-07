using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        //Два треугольника заданы длинами своих сторон.
        //Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
        //Для решения задачи можно использовать формулу Герона 

        static void GetArea(double a, double b, double c, out double s)
        {
            double p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника 1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            GetArea(x1, y1, z1, out double s1);

            Console.WriteLine("Введите стороны треугольника 2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            GetArea(x2, y2, z2, out double s2);

            if (s1 < s2)
                Console.WriteLine("Площадь 1 треугольника меньше");
            else if (s1 > s2)
                Console.WriteLine("Площадь 1 треугольника больше");
            else 
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();
        }
    }
}
