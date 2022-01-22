using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal TaxRate = 0.075M;

            Console.Write("Enter amount of sale: ");

            string userInput = Console.ReadLine();
            decimal amount = decimal.Parse(userInput);

            // Console.WriteLine(userInput);
            // Console.WriteLine(amount);

            decimal taxAmount = amount * TaxRate;

            Console.WriteLine("The tax amount is " + taxAmount.ToString("C2"));

            Console.WriteLine("The total is " + (amount + taxAmount).ToString("C2"));
            
        }
    }
}
