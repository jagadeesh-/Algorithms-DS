using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class QuickSort
    {
        public static void quickSort(int[] input)
        {

            Sort(input, 0, input.Length - 1);
            Console.WriteLine("******************Sorted array************");
            for (int index = 0; index < input.Length; index++)
            {
                Console.Write("\t" + input[index]);
            }

            Console.ReadKey();
        }

        public static void Sort(int[] input, int left, int right)
        {

            int splitter = Partition(input, left, right);

            if (right > 0 && splitter != -1)
            {
                Sort(input, left,splitter -1);
                Sort(input, splitter + 1, right);
            }
        }

        public static int Partition(int[] input, int first, int last)
        {
            int pivot = first;
            int left = first + 1;
            int right = last;

            while ( left <= right && input[left] <= input[pivot]) ++left;
            while (right > pivot && input[right] >= input[pivot]) --right;

            if (right < pivot) return -1;

            // exchange right element with pivot
            if (right < left)
            {
                swapHelper(input, pivot, right);
            }
            else
            {
                swapHelper(input, left, right);
            }

            return right; // splitter
        }

        public static void swapHelper(int[] input, int first, int second)
        {
            int temp = 0;
            temp = input[first];
            input[first] = input[second];
            input[second] = temp;
        }
    }
}
