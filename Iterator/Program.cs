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