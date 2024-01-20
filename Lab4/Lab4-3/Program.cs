using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    class Program
    {
        //Метод по введенным положительным числам A, B, C подсчитывает максимальное кол-во квадратов со стороной C, которые можно
        //вписать в прямоугольник A x B без наложения
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные числа: ");
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)   //сообщения об ошибке и нулевой случай   
            {
                Console.WriteLine("Ошибка. Введены неположительные числа");
                Console.ReadKey();
                return;
            }
            else if (c > a || c > b)     
            {
                Console.WriteLine("В прямоугольник A x B невозможно вписать ни один квадрат со стороной C");
                Console.ReadKey();
                return;
            }

 
            int ostatokA = a, ostatokB = b, rez = 0;
            while (ostatokA >= c)
            {
                while (ostatokB >= c)
                {
                    ostatokB = ostatokB - c;
                    rez++;
                }
                ostatokB = b;
                ostatokA = ostatokA - c;
            }
            Console.WriteLine("Ответ: {0}", rez);
            Console.ReadKey();
        }
    
    }
}
