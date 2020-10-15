using System;
using System.Diagnostics.Tracing;

namespace Ch_2_Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment the function you want to execute 

            //HelloName_1();
            //Sum_2();
            //Operations_3();
            //Multiplication3_4();
            //MultiplicationTable_5();
            //Average_6();
            //Range()_7;
            //CurrentDate_8();
            //YearofBirth_9();
            //Operations_10();


        }
        static void HelloName_1()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("Hello, " + name + "!");
            Console.ReadLine();

        }
        static void Sum_2()
        {
            Console.Write("Write number you want to add: ");
            int adnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the other number you want to add: ");
            int adother = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + (adnum + adother));
            Console.ReadLine();
        }
        static void Operations_3()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2 );
        }
        static void Multiplication_4()
        {
            Console.Write("Please enter the first number to multiply: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number to multiply: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the third number to multiply: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The product is: " + (a*b*c));
        }
        static void MultiplicationTable_5()
        {
            Console.Write("Input the number you want to see the muliplication table of: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            while (counter <11)
            {
                Console.WriteLine(number + " * " + counter + " = " + (number*counter));
                counter ++;
            }

        }
        static void Average_6()
        {
            Console.Write("Input the first number to take the average of: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the second number to take the average of: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the third number to take the average of: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the fourth number to take the average of: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double average = (a+b+c+d)/4;
            Console.WriteLine("The average is: " + average);
        }
        static void Range_7()
        {
            Console.WriteLine("Input an integer you want to check if within range between 100 and 200: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=100 && a<= 200)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void CurrentDate_8()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("Current date is: ");
            Console.WriteLine("Day: " + time.Day);
            Console.WriteLine("Month: " + time.Month);
            Console.WriteLine("Year: " + time.Year);

        }
        static void YearofBirth_9()
        {
            Console.Write("Input your current age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the month of your birthday (in numbers): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the day of your birthday: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime time = DateTime.Now;
            if (month>time.Month)
            {
                Console.WriteLine("Your year of birth is: " + (time.Year - age - 1));
            }
            else if (month<time.Month)
            {
                Console.WriteLine("Your year of birth is: " + (time.Year - age));
            }
            else
            {
                if (day>time.Day) { Console.WriteLine("Your year of birth is: " + (time.Year - age - 1)); }
                else { Console.WriteLine("Your year of birth is: " + (time.Year - age)); }
            }
        }
        static void Operations_10()
        {
            Console.Write("Input first number (x) : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number (y) : ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input third number (z) : ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("(x+y).z = " + ((x+y)*z));
            Console.WriteLine("x.y + y.z = " + ((x*y)+(y*z)));
        }



    }
}
/*1. Write a C# Sharp program to print Hello and your name in a separate line.
2. Write a C# Sharp program to print the sum of two numbers.
3. Write a C# Sharp program to print the result of the specified operations.
-1 + 4 * 6
( 35+ 5 ) % 7
14 + -4 * 6 / 11
2 + 15 / 6 * 1 - 7 % 2
4. Write a C# program to print the output of multiplication of three numbers which will be entered by the user.
5. Write a C# program that takes a number as input and print its multiplication table.
6. Write a C# program that takes four numbers as input to calculate and print the average
7. Write a C# program to check if an given integer is within range between 100 and 200.
8. Write a C# program that display current date separating day, month, year
9. Write a C# program asking about your age and display year of birth
10. Write a C# program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z*/



