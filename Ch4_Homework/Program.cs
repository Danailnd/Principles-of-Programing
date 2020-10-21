using System;
using System.Net;

namespace Ch4_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            HW_1();
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
                for(int num = response - 1; num>-1; num--, index--)
                {
                    if(index <= 0)
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
                Console.WriteLine(result + Convert.ToString(counter+1) + result_reverse);
                if (counter != response-1) 
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
    }

}
