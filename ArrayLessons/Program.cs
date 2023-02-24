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
        static void ConsoleWriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Количество мест в отсеке {i + 1}  - {array[i]}");
            }
        }

        static int CovertUserMassedge (string userMassedge)
        {
            while (true)
            {
                int convertNumber;
                Console.WriteLine(userMassedge);
                bool result = int.TryParse(Console.ReadLine(), out convertNumber);
                if (result == true) return convertNumber;
                else Console.WriteLine($"Ошибка! Ввведенно не корректно. Попробуйте еще раз.");
            }
            
        }
          
        static void Main(string[] args)
        {
            int[] partAircraft = { 10, 12, 50, 50, 30 };
            bool onProgramm = true;
            while (onProgramm)
            {
                Console.SetCursorPosition(0, 20);
                ConsoleWriteArray(partAircraft);

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 0);

                
                int choice = CovertUserMassedge($"Выберите действие:\n1 - забронировать билеты,\n2 - выход из программы.\n\n\nВведите номер действия: ");
                switch (choice)
                {
                    case 1:                       
                        int numberPart = CovertUserMassedge ($"Выберите номер отсека: ");
                        int numberTickets = CovertUserMassedge ($"Введите колчество билетов: ");
                        
                        if (numberTickets > partAircraft[numberPart - 1])
                        {
                            Console.WriteLine($"Ошибка! Количество запрошенных билетов превышает имеющиеся.");
                        
                        }
                        else
                        {
                            partAircraft[numberPart - 1] -= numberTickets;
                            Console.SetCursorPosition(0, 10);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Операция выполнена успешно. Отсек номер - {numberPart}. Забронированно билетов  - {numberTickets}.");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.SetCursorPosition(0, 10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"До свиданния.\nСпасибо что воспользовались услугами нашего сервиса.\nПриходите еще.");
                        onProgramm = false;
                        break;
                    default:
                        Console.Clear();
                        Console.SetCursorPosition(0, 10);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ошибка! Неверный номер действия");
                        break;
                }
                Console.ReadKey();   
                Console.Clear();
            }
        }
    }
}
