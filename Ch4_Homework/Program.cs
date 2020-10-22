using System;
using System.Diagnostics.Tracing;
using System.Net;

namespace Ch4_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //HW_1();
            HW_2();
            Console.ReadLine();
        }
        static void HW_1()
        {
            Console.WriteLine("Input the highest number you want the pyramid to reach. (34 is the max good looking value)");
            Console.Write("(Note that to reach the assigned output from the homework you can input 5): ");
            int response = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            string[] a_out = new string[response];
            string[] a_reverse = new string[response];
            string[] a_backwards = new string[response - 1];

            int index;

            for (int counter = 0; counter < response; counter++)
            {
                index = counter;
                for (int num = response - 1; num > -1; num--, index--)
                {
                    if (index <= 0)
                    {
                        a_out[num] = " ";
                    }
                    else
                    {
                        a_out[num] = Convert.ToString(index);
                    }

                }
                string result = string.Join("", a_out);
                Array.Reverse(a_out);
                string result_reverse = string.Join("", a_out);
                Console.WriteLine(result + Convert.ToString(counter + 1) + result_reverse);
                if (counter != response - 1)
                {
                    a_backwards[counter] = result + Convert.ToString(counter + 1) + result_reverse;
                }
            }
            Array.Reverse(a_backwards);
            foreach (string i in a_backwards)
            {
                Console.WriteLine(i);
            }
        }
        static void HW_2()
        {
            bool forever = true;
            while (forever)
            {

                Console.WriteLine("1. Encode message.");
                Console.WriteLine("2. Decode message.");
                Console.WriteLine("3. Exit.");
                Console.WriteLine("Select the number that coresponds with your desired operation: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Input a message to be encoded: ");
                        string input = Console.ReadLine();
                        if (input != input.ToLower())
                        {
                            input = input.ToLower();
                            Console.WriteLine("Note that all letters have been lowered for the sake of my sanity.");
                        }
                        Console.WriteLine("Your encoded message is: \n");
                        Console.WriteLine(Encode(input) + "\n");
                        break;
                    case 2:
                        Console.WriteLine("Input a message to be decoded: ");
                        input = Console.ReadLine();
                        if (input != input.ToLower())
                        {
                            input = input.ToLower();
                            Console.WriteLine("Note that all letters have been lowered for the sake of my sanity.");
                        }
                        Console.WriteLine("Your decoded message is: \n");
                        Console.WriteLine(Decode(input) + "\n");

                        break;
                    case 3:
                        forever = false;
                        break;
                    default:
                        Console.WriteLine("Error please input an integer from 1 to 3. ");
                        break;
                }

            }

        }
        static string Encode(string input)
        {
            string result = "";
            char[] original = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '!', '.', '?', '-' };
            char[] random = { 'f', 'g', 'h', 'i', 'j', 'k', 'l', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'm', 'n', 'o', 'p', 'q', 'r', 's', ' ', '!', '.', '?', '-' };
            foreach (char i in input)
            {
                int counter = -1;
                bool iterate = true;
                while (iterate)
                {
                    counter++;
                    if (original[counter] == i)
                    {
                        iterate = false;
                    }
                }
                result = result + random[counter];
            }
            return result;
        }
        static string Decode(string input)
        {
            string result = "";
            char[] original = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '!', '.', '?', '-' };
            char[] random = { 'f', 'g', 'h', 'i', 'j', 'k', 'l', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'm', 'n', 'o', 'p', 'q', 'r', 's', ' ', '!', '.', '?', '-' };
            foreach (char i in input)
            {
                int counter = -1;
                bool iterate = true;
                while (iterate)
                {
                    counter++;
                    if (random[counter] == i)
                    {
                        iterate = false;
                    }
                }
                result = result + original[counter];
            }
            return result;
        }
    }

}
