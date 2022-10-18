// Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte result;
            string input;
            bool IsTrue;


            input = Console.ReadLine();
            IsTrue = byte.TryParse(input, out byte day);


            while(IsTrue == false || day < 1 || day > 7)
            {
                Console.Write("Необходимо ввести число от 1 до 7.\nПовторите ввод: ");
                input = Console.ReadLine();
                IsTrue = byte.TryParse(input, out day);
            }


            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник - день тяжёлый");
                    break;

                case 2:
                    Console.WriteLine("Вторник - день рабочий");
                    break;

                case 3:
                    Console.WriteLine("Среда - середина рабочей недели");
                    break;

                case 4:
                    Console.WriteLine("Четверг - четвёртый рабочий день");
                    break;

                case 5:
                    Console.WriteLine("Пятница - последний рабочий день");
                    break;

                case 6:
                    Console.WriteLine("Суббота - выходной день");
                    break;

                case 7:
                    Console.WriteLine("Воскресенье - выходной день");
                    break;
            }

            Console.ReadKey();
        }
    }
}
