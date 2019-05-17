using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int input = UserInput.GetUserInputAsInteger("Enter the position of the prime number you seek? ");
                UserInput.Display(string.Format($"The number {input} is " +
                    $"{PrimeNumberFinder.GetPrimeNumberAtPosition(input)}"));

            } while (UserInput.UserConfirmationPrompt("Find another(Y/N)? "));

        }
    }
}
