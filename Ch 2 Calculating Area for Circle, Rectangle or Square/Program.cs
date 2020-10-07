using System;

namespace Ch_2_Calculating_Area_for_Circle__Rectangle_or_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;

            do
            {
                Console.WriteLine("Hello. Please choose one of the following shapes to calculate the area of: ");
                Console.Write("rectangle, triangle or circle: ");
                string shape = Console.ReadLine();
               
                if (shape == "rectangle")
                {
                    Console.WriteLine("Please Input Length ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Input Width ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    double Area = width * length;
                    double Perimeter = 2 * (width + length);
                    Console.WriteLine("The area of your " + shape + " is: " + Area);
                    Console.WriteLine("The perimeter of your " + shape + " is: " + Perimeter);
                }
                else if (shape == "triangle")
                { bool check = false;
                    while (!check)
                    {
                        Console.WriteLine("Please input the first side ");
                        double side1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please input the second side ");
                        double side2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please input the third side ");
                        double side3 = Convert.ToDouble(Console.ReadLine());
                        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                        {
                            double Perimeter = side1 + side2 + side3;
                            double Area = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - side1) * (Perimeter / 2 - side2) * (Perimeter / 2 - side3));
                            // sqrt (p (p − a)(p − b)(p − c)) -> Heron's Formula where p is perimeter/2
                            Console.WriteLine("The area of your " + shape + " is: " + Area);
                            Console.WriteLine("The perimeter of your " + shape + " is: " + Perimeter);
                            check = true;
                        }
                        else
                        {
                            Console.WriteLine("No triangle can exist with the given sides. ");
                            Console.WriteLine("Please try again. (The sum of two sides of a triangle is always bigger than the third side) ");

                        }
                    }
                }
                else if (shape == "circle")
                {
                    Console.WriteLine("Please input radius ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double Area = Math.Pow(radius, 2) * Math.PI; 
                    double Perimeter = 2 * radius * Math.PI;
                    Console.WriteLine("The area of your " + shape + " is: " + Area);
                    Console.WriteLine("The circumference of your " + shape + " is: " + Perimeter);
                }
                else
                {
                    Console.WriteLine("Please type one of the three shapes listed above. (Note that the program is case-sensitive) ");
                    repeat = true;
                }
            } while (repeat);
            Console.ReadLine();

        }
    }
}
