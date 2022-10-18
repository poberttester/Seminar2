//Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result, separeteNumber = 0;
            string input;
            bool IsTrue;


            input = Console.ReadLine();
            IsTrue = int.TryParse(input, out int number);


            while (IsTrue == false)     // проверка, что данные ведённые пользователем являются числом int
            {
                Console.WriteLine("Число должно быть в диапазоне integer");
                Console.Write("Повторите ввод: ");
                input = Console.ReadLine();
                IsTrue = int.TryParse(input, out number);
            }


            if (number < 100)    // проверка, что число является трёхзначным
            {
                Console.WriteLine("Третьего числа нет");
                goto link;
            }

            
            for (int temp = number; temp > 99; temp /= 10)  // уменьшаем число до трёхзначного
            {                
                separeteNumber = temp;
            }

            result = separeteNumber % 10;
            Console.WriteLine($"Третья цифра заданного числа: {result}");

           link:
                Console.ReadKey();
        }
    }
}