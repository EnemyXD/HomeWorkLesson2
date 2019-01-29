using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Mission4
{
  /// <summary>
  /// Эта программа проверяет логин и пароль
  /// </summary>
    class check
    {
        public static int Checkout(int s)
        {

            int shot = 3;

            Console.Write("Введите логин:");
            string login = Console.ReadLine();

            Console.Write("Введите пароль:");
            string password = Console.ReadLine();

            if (login == "root")
            {
                do
                {
                    if (password =="GeekBrains")
                    {
                        shot = 2;
                    }

                    shot--;

                    if (password !="GeekBrains")
                    {
                        Console.Write($"Пароль введен не верно. Осталось попыток {shot}.\nВведите пароль:");
                        password = Console.ReadLine();
                    }
                    
                } while (shot != 1);

                if (password !="GeekBrains")
                {
                    Console.WriteLine("Пароль введен не верно.");
                }else Console.WriteLine("Добро пожаловать!");
            }
            else Console.WriteLine("Данные введены не верно.");

            return s;
        }
    }
}
