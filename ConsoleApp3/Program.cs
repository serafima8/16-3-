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
            //1

            Console.Write("Year ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day ");
            int day = int.Parse(Console.ReadLine());
            DateClass date = new DateClass(year, month, day);
            DateTime date1 = new DateTime(year, month, day);
            Console.WriteLine(date1.ToShortDateString());
            Console.WriteLine($"Предыдущий день: {date.Previous().ToShortDateString()}");
            Console.WriteLine($"Последующий день: {date.Next().ToShortDateString()}");
            date.Kolvo();

            //2

            Console.Write("Введите первую дату: ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите вторую дату: ");
            DateTime date3 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Количество времени между датами: {date3.Subtract(date2)}");

            //3

            Console.Write("Введите время 1 процедуры: ");
            DateTime time1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите время 2 процедуры: ");
            DateTime time2 = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите общее количество процедур: ");
            int kolvo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kolvo; i++)
            {
                DateTime a = time1.AddMinutes(i * (time2 - time1).TotalMinutes);
                Console.WriteLine($"Расписание процедуры {i + 1}: {a.ToShortTimeString()}");
            }

            Console.ReadKey();
        }
    }
}
