using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            int number = 0;
            int result = 0;
            try
            {
                while (true)
                {
                    Console.WriteLine("Введите целое число больше 0.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                
            }
            catch
            {
                Console.WriteLine("Неправильный формат ввода данных.");
            }
            if (number <= 0)
            {
                Console.WriteLine("Неправильно введено значение.");
                Console.ReadKey();
                return;
            }
            for (int i = 1; i <= (2 * number - 1); i += 2)
            {
                result += i;
                Console.WriteLine(result);
            }
            //Задача 2
            var count = 0;
            var negative_count = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                    count++;
                else
                    if (number != 0)
                    negative_count++;
            }
            while (number != 0);
            if (count > negative_count)
                Console.WriteLine("Положительных чисел больше.");
            else
                if (count < negative_count)
                Console.WriteLine("Отрицательных чисел больше.");
            else
                Console.WriteLine("Количество отрицательных и положительных чисел равно.");
            //Задача 3
            double a, b, c;
            Console.WriteLine("Введите размеры прямоугольника: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадратов: ");
            c = Convert.ToInt32(Console.ReadLine());
            count = 0;
            double temp;
            while ((a - c) >= 0)
            {
                a -= c;
                temp = b;
                while (temp - c >= 0)
                {
                    temp -= c;
                    ++count;
                }
            }
            Console.WriteLine("Kоличество квадратов: {0}", count);
            Console.ReadKey();
        }
    }
}
