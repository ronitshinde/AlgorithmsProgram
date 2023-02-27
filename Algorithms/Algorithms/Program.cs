using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            InsertionSort insertion = new InsertionSort();
            Console.WriteLine("Select The Option");
            Console.WriteLine("1.Insertion Sort");
            Console.WriteLine();
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    insertion.DisplayInsertionSort();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
