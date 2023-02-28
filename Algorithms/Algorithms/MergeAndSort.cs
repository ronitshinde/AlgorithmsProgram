using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeAndSort
    {
        public void SortMerge()
        {
            int[] array = { 66, 45, 98, 40, 49, 51, 85, 99, 32 };
            Console.Write("Initial Array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            MergeSort(array);
            Console.Write("Sorted Array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }           
        }
        public void MergeSort(int[] array)
        {
            int length = array.Length;
            if (length <= 1) return;

            int middle = length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[length - middle];

            int i = 0;   // right array
            int j = 0;   // left array
            while (i < length)
            {
                if (i < middle)
                {
                    leftArray[i] = array[i];
                    i++;
                }
                else
                {
                    rightArray[j] = array[i];
                    j++;
                    i++;
                }
            }
            MergeSort(leftArray);
            MergeSort(rightArray);
            Merge(leftArray, rightArray, array);
        }
        private void Merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int i = 0, l = 0, r = 0;
            while (l < leftSize && r < rightSize)
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }
            while (l < leftSize)
            {
                array[i] = leftArray[l];
                l++;
                i++;
            }
            while (r < rightSize)
            {
                array[i] = rightArray[r];
                r++;
                i++;
            }
        }
    }
}


