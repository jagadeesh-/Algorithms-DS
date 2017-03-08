using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class MergeSort
    {
        public static void mergeSort(int []input)
        {
            int[] aux = new int[input.Length];
            // copy into aux array
            for (int index = 0; index < input.Length; index++)
            {
                aux[index] = input[index];
            }

            Sort(input, aux, 0, input.Length - 1);

            Console.WriteLine("******************Sorted array************");
            for (int index = 0; index < input.Length; index++)
            {
                Console.Write("\t" + aux[index]);
            }

            Console.ReadKey();
        }

        public static void Sort(int []input, int[]aux,int low,int high)
        {
            if (low >= high) return;
            int mid = low + (high - low) / 2;
            Sort(aux, input, low, mid);
            Sort(aux, input, mid + 1, high);
            Merge(input, aux, low, mid, high);
        }

        public static void Merge(int []input, int[]aux, int low, int mid, int high)
        {
            int i = low;
            int j = mid + 1;
            for (int k = i; k <= high; k++)
            {
                if (j > high) aux[k] = input[i++];
                else if (i > mid) aux[k] = input[j++];
                else if (input[i] < input[j]) aux[k] = input[i++];
                else aux[k] = input[j++];
            }

            for (int k = 0; k <= high; k++)
            {
                Console.Write("\t" + aux[k]);
            }

            Console.WriteLine();
          
        }
    }
}
