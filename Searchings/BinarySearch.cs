using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class BinarySearch
    {

        public static void binarySearch(int[] input, int searchEle)
        {
            int low = 0;
            int high = input.Length - 1;
            int position = search(input, searchEle, low, high);
            if (position != -1)
            {
                Console.WriteLine("element {0} found at {1}", searchEle, position);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Element {0} not found", searchEle);
                Console.ReadKey();

            }
        }

        public static int search(int[] input, int data, int low, int high)
        {
            int mid = low + (high - low) / 2;
            int position = -1;
          
            if (input[mid] == data)
            {
                return mid; 
            }

            if (low > high) return -1;
           
                if (data < input[mid])
                {
                    high = mid - 1;
                    position = search(input, data, low, high);
                }
                else
                {
                    low = mid + 1;
                    position = search(input, data, low, high);
                }


                return position;
        }

    }
}
