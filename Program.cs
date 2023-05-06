using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x4;
            int y4;
            Console.WriteLine("Введите координаты первой вершины");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей вершины");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            if ((x1 == x2 || x1 == x3 || x2 == x3) & (y1 == y2 || y1 == y3 || y2 == y3))
            {
                if (x1 == x2)
                {
                    x4 = x3;
                    Console.WriteLine("Координата Х4 ={0}", x4);
                }
                if (x1 == x3)
                {
                    x4 = x2;
                    Console.WriteLine("Координата Х4 ={0}", x4);
                }

                if (x2 == x3)

                {
                    x4 = x1;
                    Console.WriteLine("Координата Х4 ={0}", x4);
                }


                if (y1 == y2)
                {
                    y4 = y3;
                    Console.WriteLine("Координата Y4 ={0}", y4);
                }
                if (y1 == y3)
                {
                    y4 = y2;
                    Console.WriteLine("Координата Y4 ={0}", y4);
                }

                if (y2 == y3)

                {
                    y4 = y1;
                    Console.WriteLine("Координата Y4 ={0}", y4);
                }
            }
            else { Console.WriteLine("Стороны прямоугольника не параллельны осям OX и OY"); }


            Console.ReadKey();
        }
    }
}
