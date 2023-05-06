using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Укажите свой возраст:");
            int n = Convert.ToInt32(Console.ReadLine());
            int o = n % 10;
            if (n>=20&n<=69) 
            {
                switch (o)
                {
                    case 1:
                        {
                            Console.WriteLine("Ваш возраст прекрасен! Вам {0} год!", n);
                            break;
                        }
                    case 2:
                    case 3:
                    case 4:
                        {
                            Console.WriteLine("Чудесно! Вам {0} года!", n);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Я знал, знал!!! Вам {0} лет!", n);
                            break;
                        }
                }
                
            }
            else { Console.WriteLine("Ай-яй! Ваш возраст не находится в диаппазоне 20-69 лет! А у нас здесь своя песочница!"); }


            Console.ReadKey();
        }
    }
    }


