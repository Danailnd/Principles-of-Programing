using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Ch3_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uncoment the function you want to execute

            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4_UserInput();
            //Task_4_DateTimeInput();
            //Task_5();
            

            Console.ReadLine();
        }
        static void Task_1()
        {
            Console.Write("Write the measurements of the first side of your triangle: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write the measurements of the second side of your triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write the measurements of the third side of your triangle: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a+b<c || a+c<b || b+c<b)
            {
                Console.WriteLine("Please input the sides of a real triangle. (the sum of two sides is always bigger than the third)");
            }
            
            else if (a==b && b==c)
            {
                Console.WriteLine("All three sides are equal.");
            }else if (a == b)
            {
                Console.WriteLine("The first and second side are equal.");
            }
            else if (a == c)
            {
                Console.WriteLine("The first and third side are equal.");
            }
            else if (c == b)
            {
                Console.WriteLine("The second and third side are equal.");
            }
            else
            {
                Console.WriteLine("No sides are equal.");
            }

            /*Write a console program asking about three sides of the triangle and check:
            If 2 of the sides are equal and print the result 
            If 3 of the sides are equal and print the result
            If there are 2 or more equal sides – print their names*/

        }
        static void Task_2()
        {
            Console.WriteLine("Input 10 numbers.");
            int counter = 0;
            int ncounter = 0;
            double sum = 0;
            while (counter <10)
            {
                double input = Convert.ToDouble(Console.ReadLine());
                if (input>=10 && input<=20)
                {
                    sum = sum + input;
                    ncounter++;
                }
                counter++; 
            }
            Console.WriteLine("The number of numbers between 10 and 20 inputed is: " + ncounter);
            Console.WriteLine("The sum of the inputed numbers that are between 10 and 20 is: " + sum);

            /*We need to create a program to add numbers entered on the keyboard if they have values between 10 and 20.
            A program should be able to read total of 10 random numbers.
            A program should be able to display as a result
            Number of numbers between 10 and 20
            Sum of these numbers*/

        }
        static void Task_3()
        {
            Console.Write("Display you height in sentimeters: ");
            double height = Convert.ToDouble(Console.ReadLine());
            if (height>190)
            {
                Console.WriteLine("You should play Basketball.");
            }else if (height < 190 && height > 175)
            {
                Console.WriteLine("You should play Athletics.");
            }
            else
            {
                Console.WriteLine("You should play Horse Riding.");
            }

            /*Create a program to help people to choose appropriate sport.
            Program should allow user to enter his height in centimeters
            If height is bigger than 190 to display Basketball
            If height is between 175 and 190 to display Athletics
            If height is below 175 to display Horse riding*/

        }
        static void Task_4_UserInput()
        {
            Console.WriteLine("Input the day of the week and the hour of the day.");
            Console.WriteLine("(Use integers for both answers. Note that the week begins with Sunday)");
            Console.Write("Input the day of the week (between 1 and 7): ");
            int Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the hour of the day (between 0 and 23): ");
            int Hour = Convert.ToInt32(Console.ReadLine());
            
            bool error = false;
            string DayName = "";
            string Weekend_Statement = "";
            string Hour_Statement = "";
            string bonus = "";

            if (Hour >= 5 && Hour < 12) // to determine whether its moring, evening etc...
            {
                Hour_Statement = "Morning";

            }
            else if (Hour >= 12 && Hour < 18)
            {
                Hour_Statement = "Afternoon";

            }
            else if (Hour >= 18 && Hour < 23)
            {
                Hour_Statement = "Evening";
            }
            else if(Hour<5 && Hour>=0)
            {
                Hour_Statement = "Morning";
                bonus = " You should really go to bed.";
            }
            else
            {
                error = true;
            }

            
            switch (Day) //to convert numbers to days of the week
            {
                case 1:
                    DayName = "Sunday";
                    break;
                case 2:
                    DayName = "Monday";
                    break;
                case 3:
                    DayName = "Tuesday";
                    break;
                case 4:
                    DayName = "Wednesday";
                    break;
                case 5:
                    DayName = "Thursday";
                    break;
                case 6:
                    DayName = "Friday";
                    break;
                case 7:
                    DayName = "Saturday";
                    break;
                default:
                    error = true;
                    break;
            }
            if (Day==1 || Day == 7) // To determine how many days are until the weekend 
            {
                Weekend_Statement = "The weekend is here! ";
            }else
            {
                Weekend_Statement = "Weekend is coming in " + (7 - Day) + "days! ";
            }

            if (error)
            {
                Console.WriteLine("Wrong Input! Please try again.");
            }
            else
            {
                Console.WriteLine("Good " + Hour_Statement + ", today is a lovely " + DayName + "! " + Weekend_Statement + bonus);
            }

            /*Create a program to greet people depending of day of week and time of the day.
            Program should allow user to enter two numbers
            day of the week -number between 1 and 7
            hour - number between 0 and 23
            Program should visualize text like
            Good morning, it is a lovely Monday today. Weekend is coming in 5 days
            or
            Good evening, it is lovely Sunday today.Weekend is here!
            Implement function, which is taking datetime value as argument and is returning the greeting as described above.*/

        }
        static void Task_4_DateTimeInput()
        {
            DateTime time = DateTime.Now;
            string Day = Convert.ToString(time.DayOfWeek);
            int Hour = Convert.ToInt32(time.Hour);
            string Hour_Statement = "";
            string bonus = "";
            string Weekend_Statement = "";

            if (Hour >= 5 && Hour < 12) // to determine whether its moring, evening etc...
            {
                Hour_Statement = "Morning";
            }
            else if (Hour >= 12 && Hour < 18)
            {
                Hour_Statement = "Afternoon";
            }
            else if (Hour >= 18 && Hour < 23)
            {
                Hour_Statement = "Evening";
            }
            else if (Hour < 5 && Hour >= 0)
            {
                Hour_Statement = "Morning";
                bonus = " You should really go to bed.";
            }

            if (Day == "Saturday" || Day == "Sunday") // To determine how many days are until the weekend 
            {
                Weekend_Statement = "The weekend is here! ";
            }
            else
            {
                if (Day == "Monday")
                {
                    Weekend_Statement = "The weekend is coming in 5 days ! ";
                }
                if (Day == "Tuesday")
                {
                    Weekend_Statement = "The weekend is coming in 4 days ! ";
                }
                if (Day == "Wednesday")
                {
                    Weekend_Statement = "The weekend is coming in 3 days ! ";
                }
                if (Day == "Thursday")
                {
                    Weekend_Statement = "The weekend is coming in 2 days ! ";
                }
                if (Day == "Friday")
                {
                    Weekend_Statement = "The weekend is coming in 1 days ! ";
                }
            }
            Console.WriteLine("Good " + Hour_Statement + ", today is a lovely " + Day + "! " + Weekend_Statement + bonus);

        }
        static void Task_5()
        {
            /*Implement functionality asking user to enter personal data and implement validation and display appropriate messages.
            Form should ask about following data
            First name – string, required, max length = 100
            Last name – string, required, max length = 100
            Date of birth – date time, limit now - 100 years
            Student number – string, length 12, format YYYYFFSSNNNN
            YYYY – year
            FF – code of faculty – range 01 to 09
            SS – code of specialty – range 01 to 05
            NNNN number within specialty*/

        }
    }
}
