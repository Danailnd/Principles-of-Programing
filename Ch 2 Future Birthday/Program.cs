using System;
using System.Transactions;

namespace Ch_2_Future_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Write your current age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your future age: ");
            int futureAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your Birthday Month: ");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your Birthday day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime time = DateTime.Now;
            int currentyear = time.Year;
            string FutureDate = day + "/" + Month + "/" + (currentyear + futureAge - age);
            Console.WriteLine("In " + FutureDate + " you will be " + futureAge + " years old ! ");
            Console.ReadLine();


        }
    }
}
/*Write a console program to ask user about
            Current age
            Future age
            Birthday month
            Birthday day of month

            Program should be able to calculate and display exact date when you are going to celebrate your future birthday (e.g. when you will reach Future age)*/
