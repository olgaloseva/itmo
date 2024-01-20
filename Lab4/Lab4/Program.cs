using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        //Метод по введенному положительному целому числу возвращает его квадрат, используя формулу N2=1 + 3 + 5 + ... + (2*N – 1)
        //В цикле выводится текущее значение суммы, т.е. будут квадраты всех целых чисел от 1 до N
      
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)     //сообщение об ошибке
            {
                Console.WriteLine("Ошибка. Введенное число не является целым положительным");
            }
            
            int summ = 0;

            for (int i=1; i<=(2 * n - 1); i=i+2)
            {
                summ = summ + i;
                Console.WriteLine(summ);

            }
            Console.ReadKey();
        }
    }
}
