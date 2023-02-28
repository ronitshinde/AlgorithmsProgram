using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PrimeNumber
    {
        public void PrimeCheck(int minNum, int maxNum)
        {
            Console.WriteLine("Prime Numbers : ");
            for (int i = minNum; i <= maxNum; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

