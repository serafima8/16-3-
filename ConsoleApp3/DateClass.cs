using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class DateClass
    {
        /// <summary>
        /// Создание поля DateTime data
        /// </summary>
        DateTime data;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public DateClass() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
            year = year;
            month = month;
            day = day;
        }
        /// <summary>
        /// Свойства поля DateTime data
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; } 
        }
        /// <summary>
        ///  Метод, позволяющий вычислить дату предыдущего дня
        /// </summary>
        /// <returns></returns>
        public DateTime Previous()
        {
            return data.AddDays(-1);
        }
        /// <summary>
        /// Метод, позволяющий вычислить дату последующего дня
        /// </summary>
        /// <returns></returns>
        public DateTime Next()
        {
            return data.AddDays(1);
        }
        /// <summary>
        /// Метод, позволяющий вычислить кол-во дней до конца месяца 
        /// </summary>
        public void Kolvo()
        {
            DateTime DaysInMonth = new DateTime();
            Console.WriteLine($"Количество дней до конца месяца: {DateTime.DaysInMonth(data.Year, data.Month) - data.Day}");
        }
    }
}
