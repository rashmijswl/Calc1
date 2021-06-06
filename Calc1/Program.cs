using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    public class Program
    {
        public double addition(double a, double b)
        {
            double c = a + b;
            return c;
        }
        public double substract(double a, double b)
        {
            double c = a - b;
            return c;
        }
        public double multiplication(double a, double b)
        {
            double c = a * b;
            return c;
        }
        public double division(double a, double b)
        {
            double c = a / b;
            return c;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            bool check;
            // int value_valid = 1;
            double first_number = 0, second_number = 0, result = 0;
            do
            {
                Console.WriteLine("Enter first value");
                var num1 = Console.ReadLine();
                check = double.TryParse(num1, out first_number);
                if (check == false)
                    Console.WriteLine("Invalid Input. Try Again.\n");
            } while (check == false);

            do
            {

                Console.WriteLine("Enter second number");
                var num2 = Console.ReadLine();
                check = double.TryParse(num2, out second_number);
                if (check == false)
                    Console.WriteLine("Invalid input. Try Again.\n");
            } while (check == false);

            int valid_operation = 1;

            do
            {
                Console.WriteLine("Select one of the below operations");
                Console.WriteLine("1. Addition\n2. Substraction\n3. Multiplication\n4. Division");
                var operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        result = p1.addition(first_number, second_number);
                        valid_operation = 0;
                        Console.WriteLine("Output is {0}", result);
                        break;

                    case "2":
                        result = p1.substract(first_number, second_number); ;
                        valid_operation = 0;
                        Console.WriteLine("Output is {0}", result);
                        break;

                    case "3":
                        result = p1.multiplication(first_number, second_number); ;
                        valid_operation = 0;
                        Console.WriteLine("Output is {0}", result);
                        break;

                    case "4":
                        result = p1.division(first_number, second_number); ;
                        valid_operation = 0;
                        Console.WriteLine("Output is {0}", result);
                        break;

                    default:
                        Console.WriteLine("Invalid operation type. Please enter correct operation type ");
                        valid_operation = 1;
                        break;
                }
            } while (valid_operation == 1);
        }
    }
}
