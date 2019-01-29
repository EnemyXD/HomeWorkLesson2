using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков
//2. Написать метод подсчета количества цифр числа.

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Число: ");
            Console.WriteLine("Цифр: " + CalculateNumbers.Calculate(Console.ReadLine()));
            Console.ReadKey();

        }

        
    }
}
