using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_In_A_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberAmount = 0;

            Console.WriteLine("Number Sum \n----------\n");
            numberAmount = validateIntInput("Provide amount of numbers to sum");

            double[] numbers = new double[numberAmount];

            for (int i = 0; i < numberAmount; i++)
            {
                numbers[i] = validateDoubleInput("Provide number to include in sum"); ;
            }
            
            Console.WriteLine("Total sum: " + numbers.Sum());
            Console.ReadLine();
        }

        private static int validateIntInput (string message)
        {
            bool valid = false;
            int bridgeValue = 0;
            int returnValue = 0;
            while (valid == false)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out bridgeValue))
                {
                    valid = true;
                    returnValue = bridgeValue;
                }
                else
                    Console.WriteLine("Invalid Value");
            }
            return returnValue;
        }

        private static double validateDoubleInput(string message)
        {
            bool valid = false;
            double bridgeValue = 0;
            double returnValue = 0;
            while (valid == false)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (double.TryParse(input, out bridgeValue))
                {
                    valid = true;
                    returnValue = bridgeValue;
                }
                else
                    Console.WriteLine("Invalid Value");
            }
            return returnValue;
        }
    }
}
