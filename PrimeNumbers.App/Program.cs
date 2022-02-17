using System;

namespace PrimeNumbers.App
{
    class Program
    {
        static void Main()
        {
            int lowLimit = 2;
            int upLimit = 100;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Программа для генерации ПРОСТЫХ чисел в диапазоне.");
            Console.WriteLine(" ");

            while (lowLimit < upLimit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Введите целое число (больше 1) для НИЖНЕЙ границы диапазона: ");
                string strLowLimit = Console.ReadLine();
                bool resLowLimit = int.TryParse(strLowLimit, out lowLimit);
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Введите целое число (больше 1) для ВЕРХНЕЙ границы диапазона: ");
                string strUpLimit = Console.ReadLine();
                bool resUpLimit = int.TryParse(strUpLimit, out upLimit);
                
                if (!resLowLimit || !resUpLimit)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Только цифры, пожалуйста!");
                    Console.WriteLine("Давайте попробуем заново:");
                    Console.WriteLine();
                    lowLimit = 2;
                    upLimit = 100;
                    continue;
                }

                if (lowLimit > upLimit || lowLimit < 2 || upLimit < 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Значение больше 1, пожалуйста, или верхняя граница не должна быть больше нижней!");
                    Console.WriteLine("Давайте попробуем заново:");
                    Console.WriteLine();
                    lowLimit = 2;
                    upLimit = 100;
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш набор ПРОСТЫХ чисел в введённом диапазоне:");

            do
            {
                int i;

                for (i = 2; i <= lowLimit; i++)
                {
                    if (lowLimit % i == 0)
                        break;
                }

                if (i == lowLimit)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(lowLimit + "\t");
                }

                lowLimit++;

            } while (lowLimit <= upLimit);
        }
    }
}