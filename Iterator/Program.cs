using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }    
class MonthWithDays {
    public string Date {get;set;}
    public int Days {get;set;}
}

    class DaysInMonthEnumerator : IEnumerable<MonthWithDays>
    {
        private int year = 5;
        private int month = 0;
        
        public MonthWithDays Current => new MonthWithDays() {
            Date = $"{year.ToString().PadLeft(4, '0')}-{month}",
            Days = DateTime.DaysInMonth(year, month)
        };
        
        public IEnumerator<MonthWithDays> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}