/**********************************
 * CIS 3343 
 * John Velazquez
 **********************************
 * Basic Calculator
 **********************************
 * Takes to number inputs and uses
 * an inputted arithmetic operator
 * and generates a number.
 **********************************/

using System;
namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SimpleCalc v1.0");

            Console.Write("\nEnter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the math operator (+, -, *, /): ");
            String op = Console.ReadLine();

            if(string.Equals(op,"+"))
                Console.Write("\nThe answer is: " + (num1 + num2));
            else if(string.Equals(op, "-"))
                Console.Write("\nThe answer is: " + (num1 - num2));
            else if (string.Equals(op, "*"))
                Console.Write("\nThe answer is: " + (num1 * num2));
            else if (string.Equals(op, "/"))
                Console.Write("\nThe answer is: " + (num1 / num2));

            Console.WriteLine();
        }
    }
}
