using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number;
            int summa;

            summa = 0;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 0 && number % 2 == 1)
                {
                    Console.WriteLine(number);
                    summa += number;
                }


            } while (number !=0);

            Console.WriteLine(summa);

            Console.ReadKey();
        }
    }
}
