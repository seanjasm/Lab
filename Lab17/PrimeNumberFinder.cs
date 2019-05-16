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
            list.Add(2);
            int nextPrimeNumber = 3;

            while (list.Count < number)
            {
                int sqrt = (int)Math.Sqrt(nextPrimeNumber);

                bool isPrime = true;

                for (int i = 0; list[i] <= sqrt; i++)
                {
                    if (nextPrimeNumber % list[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    list.Add(nextPrimeNumber);
                }
                nextPrimeNumber += 2;
            }
            return list[number - 1];
        }
    }
}

