using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков
//1. Написать метод, возвращающий минимальное из трех чисел.


namespace Mission1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());

            int MinNumber = ReturnNumber.Return(n1, n2, n3);

            Console.WriteLine(MinNumber);

            Console.ReadKey();

        }

    }
}
