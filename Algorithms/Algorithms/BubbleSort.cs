using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort
    {
        public void DisplayBubbleSort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp, z;
            Console.WriteLine("Initial Array :");
            for (z = 0; z < arr.Length; z++)
            {
                Console.Write(arr[z] + " ");
            }
            Console.WriteLine();
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array: ");
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }
        }
    }
}
