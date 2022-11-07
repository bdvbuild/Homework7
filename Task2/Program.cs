using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        static void GetParams(double a, out double s, out double v)
        {
            s = 6 * (a * a);
            v = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            GetParams(a, out double s, out double v);
            Console.WriteLine("Площадь куба = {0:.00}; объем куба = {1:.00}.", s, v);
            Console.ReadLine();
        }
    }
}
