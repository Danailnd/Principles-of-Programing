using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In 10 years you will be " +(age+10) + " years old.");
            Console.ReadLine();
        }
    }
}
