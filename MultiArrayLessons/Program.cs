using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrayLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] authors = { { "Александр Пушкин", "Михаил Лермонтов", "Михаил Шолоков" }, 
                                { "Артур Кларк", "Стивен Кинг", "Алексей Пантелеев" }, 
                                { "Эрих Мария Ремарк", "Антон Чехов", "Рей Бредбери" } };

            Console.SetCursorPosition(0, 20);
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine($"В нашей библиотеке в наличии:");
            for (int i = 0; i < authors.GetLength(0); i++)
            {
                Console.WriteLine($"На полке № {i + 1} находится автор: ");
                for (int j = 0; j < authors.GetLength(1); j++) 
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.Write(authors[i, j] + ", ");
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);

            Console.Write($"Для нахождения местоположения книги по автору введите имя и фамилию автора: ");
            string userMassedge = Console.ReadLine();
            for (int i = 0; i < authors.GetLength(0); i++)
            {                
                for (int j = 0; j < authors.GetLength(1); j++)
                {
                    string author = authors[i, j];
                    bool comparison = userMassedge.ToLower() == author.ToLower();
                    if (comparison)
                    {
                        Console.WriteLine($"Искомый автор находится на полке {i + 1} под номером {j + 1}");
                    }                    
                }
                
            }
        }
    }
}
