using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class Program
    {
        //Метод по введенной поледовательности целых чисел определяет каких положительных или отрицательных чисел больше
        //и выводит соответствующее сообщение
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел. 0 - окончание последовательности: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.Write("Ошибка. Не задано ни одного числа в последовательности");
            }
            
            int plusN = 0, minusN = 0;

            do
            {
                if (n > 0)
                {
                    plusN++;
                }
                else
                {
                    minusN++;
                }
                n = Convert.ToInt32(Console.ReadLine());
            } while (n != 0);

            if (plusN > minusN)
            {
                Console.Write("В последовательности больше положительных чисел");
            }
            else if (plusN == minusN)
            {
                Console.Write("В последовательности одинаковое количество положительных и отрицательных чисел");
            }
            else
            {
                Console.Write("В последовательности больше отрицательных чисел");
            }
            Console.ReadKey();
        }
    }
}
