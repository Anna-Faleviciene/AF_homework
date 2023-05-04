using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружности:");
            double L = Convert.ToDouble(Console.ReadLine());
            double R = L / (2 * Math.PI);
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Радиус = {0}", R);
            Console.WriteLine("Площадь круга = {0}", S);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
