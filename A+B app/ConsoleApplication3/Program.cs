using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = 0;
            double numberTwo = 0;
            //Used to see if user entered a correct #
            

            Console.WriteLine("Sum Application \n---------------\n");
            verifyInput("Provide Number 1", ref numberOne);
            verifyInput("Provide Number 2", ref numberTwo);

            Console.WriteLine("Result: " + (numberOne+numberTwo));
            Console.ReadLine();
        }

        private static void verifyInput (string message, ref double number)
        {
            string input;
            double value;
            bool accepted = false;
            while (accepted == false)
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                if(double.TryParse(input, out value))
                {
                    accepted = true;
                    number = value;
                }
            }
        }
    }
}
