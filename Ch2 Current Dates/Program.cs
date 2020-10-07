using System;

namespace Ch2_Current_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("Current date and time is: " + time);
            int year = 10 + time.Year;
            Console.WriteLine("In 10 years the date will be: " + time.Day + "/" + time.Month + "/" + year);
            Console.Write("Please input an year: ");
            int input = int.Parse(Console.ReadLine());
            year = input + time.Year;
            Console.WriteLine("In 10 years the date will be: " + time.Day + "/" + time.Month + "/" + year);
            Console.ReadLine();
        }
    }
}
