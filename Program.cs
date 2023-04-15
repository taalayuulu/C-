using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод чисел от пользователя
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Сравнение чисел и вывод результата
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} больше, чем {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} меньше, чем {num2}");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

            // Ввод трех чисел 

            Console.WriteLine("Введите первое число: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            float num3 = Convert.ToSingle(Console.ReadLine());

            // Находим максимальное число
            float maxNum = Math.Max(num1, Math.Max(num2, num3));

            // Выводим максимальное число
            Console.WriteLine("Максимальное число: " + maxNum);




            // Ввод числа от пользователя
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Проверка на четность
            if (number % 2 == 0)
            {
                Console.WriteLine("Число " + number + " является четным.");
            }
            else
            {
                Console.WriteLine("Число " + number + " не является четным.");
            }

            // Ввод числа N от пользователя
            Console.WriteLine("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Четные числа от 1 до " + N + ": ");
            // Цикл для вывода четных чисел от 1 до N
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
