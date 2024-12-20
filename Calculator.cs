using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public static void Calculate(double num1, double num2, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Division by zero error.");
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }
            Console.WriteLine("Result: " + result);
        }
    }
}
