using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] partAircraft = { 10, 12, 50, 50, 30 };

            Console.SetCursorPosition(0, 20);
            for (int i = 0; i < partAircraft.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Количество мест в отсеке {i + 1}  - {partAircraft[i]}");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);

            Console.Write($"Выберите действие:\n1 - забронировать билеты,\n2 - выход из программы.\n\n\nВведите номер действия: ");
            int choiceUser = int.Parse(Console.ReadLine());
            switch (choiceUser)
            {
                case 1:
                    Console.Write($"Выберите номер отсека: ");
                    int numberPart = int.Parse(Console.ReadLine());
                    Console.Write($"Введите колчество билетов: ");
                    int numberTickets = int.Parse(Console.ReadLine());


                    break;
                case 2:
                    Console.Clear();
                    Console.SetCursorPosition(0, 10);
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine($"До свиданния.\nСпасибо что воспользовались услугами нашего сервиса.\nПриходите еще.");
                    break;
            }
        }
    }
}
