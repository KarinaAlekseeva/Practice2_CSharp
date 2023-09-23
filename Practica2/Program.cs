using System.Reflection.Emit;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите команду из списка:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод всех делителей числа");
            Console.WriteLine("4. Выход");

            int oper = Convert.ToInt32(Console.ReadLine());
            while (oper != 4)
            {
                if (oper == 1)
                {
                    NumberGame();
                    Console.WriteLine("Выберите команду из списка:");
                    Console.WriteLine("1. Угадай число");
                    Console.WriteLine("2. Таблица умножения");
                    Console.WriteLine("3. Вывод всех делителей числа");
                    Console.WriteLine("4. Выход");
                    oper = Convert.ToInt32(Console.ReadLine());

                }

                if (oper == 2)
                {
                    Table();
                    Console.WriteLine("Выберите команду из списка:");
                    Console.WriteLine("1. Угадай число");
                    Console.WriteLine("2. Таблица умножения");
                    Console.WriteLine("3. Вывод всех делителей числа");
                    Console.WriteLine("4. Выход");
                    oper = Convert.ToInt32(Console.ReadLine());

                }

                if (oper == 3)
                {
                    Delit();
                    Console.WriteLine();
                    Console.WriteLine("Выберите команду из списка:");
                    Console.WriteLine("1. Угадай число");
                    Console.WriteLine("2. Таблица умножения");
                    Console.WriteLine("3. Вывод всех делителей числа");
                    Console.WriteLine("4. Выход");
                    oper = Convert.ToInt32(Console.ReadLine());
                }

            }     
        }

        static void NumberGame()
        {
            Random rand = new Random();

            int i = rand.Next(101);

            Console.WriteLine("Угадай число от 0 до 100");

            int numb = Convert.ToInt32(Console.ReadLine());

            while (i < 100)
            {
                if (numb == i)
                {
                    {
                        Console.WriteLine("Угадал!");
                        return;
                        
                    }
                }
                else if (numb > i)
                {
                    Console.WriteLine("Введи меньше");

                    numb = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Введи больше");

                    numb = Convert.ToInt32(Console.ReadLine());

                }
            }

        }
        static void Table()
        {
            int [,] table = new int[10, 10];
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    table[i,j] = i * j;
                }
            }
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Delit()
        {
            Console.WriteLine("Введите число, делители которого вы хотите найти: ");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + "\t");
                }
            
            }
        }
    }    
}
