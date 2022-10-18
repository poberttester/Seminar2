//Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

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
            int number, firstNumber, secondNumber;
            string input;
            bool IsTrue;


            input = Console.ReadLine();
            IsTrue = int.TryParse(input, out number);

            while (IsTrue == false || number < 100 || number > 999)
            {
                Console.WriteLine("Число должно быть целым и трёхзначным");
                Console.Write("Повторите ввод: ");
                input = Console.ReadLine();
                IsTrue = int.TryParse(input, out number);
            }

            firstNumber = number / 10;  //Рассчитываем первое число
            secondNumber = firstNumber % 10;  //Рассчитываем второе число

            Console.WriteLine($"Второе число {secondNumber}");

            Console.ReadKey();
        }
    }
}
