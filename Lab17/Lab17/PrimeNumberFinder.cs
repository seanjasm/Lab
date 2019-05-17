using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class PrimeNumberFinder
    {
        public static int GetPrimeNumberAtPosition(int number)
        {
            List<int> list = new List<int>();
            list.Add(2);//Set 2 to position 1 or index 0
            int nextPrimeNumber = 3;//Set 3 to position 2 or index 1

            //While the length of the list is less than the position that the user enters
            //Only Prime numbers are added to the list, so the prime number is at iindex 1 less than user number
            //This is used to exist loop when the desired prime number is reached
            //Initially, count is 1, so if user enters 1 this loop will not be entered and function returns 1
            while (list.Count < number)
            {
                //Set Sqrt to the squareroot of next prime number
                int sqrt = (int)Math.Sqrt(nextPrimeNumber);

                bool isPrime = true;

                //While Sqrt is less than or equal to the index of i in the list
                //This loops stops when the current item in list is greater than the square root of the current prime number
                for (int i = 0; list[i] <= sqrt; i++)
                {
                    //If the prime number is divisible by the items in the list up to a value less than its square root
                    if (nextPrimeNumber % list[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    //Prime number is added to list while the index is less than the position user specifies
                    list.Add(nextPrimeNumber);
                }
                //Move skip even numbers
                nextPrimeNumber += 2;
            }
            
            return list[number - 1];
        }
    }
}

