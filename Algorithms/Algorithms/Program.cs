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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select The Option");
                Console.WriteLine("1.Insertion Sort \n2.Bubble Sort \n3.Merge Sort");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        InsertionSort insertion = new InsertionSort();
                        insertion.DisplayInsertionSort();
                        break;
                    case 2:
                        BubbleSort bubble = new BubbleSort();
                        bubble.DisplayBubbleSort();
                        break;
                    case 3:
                        MergeAndSort merge = new MergeAndSort();
                        merge.SortMerge();
                        Console.WriteLine();
                        break;
                    case 4:
                        flag = false;
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
