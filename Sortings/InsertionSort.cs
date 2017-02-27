using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithms
{
    public class InsertionSort
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Insertion Sort !");
            int size = Convert.ToInt16(Console.ReadLine());
            Console.Write(size);
            int [] a = new int[size];
            for (int i =0; i < size; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            
            // insertion sort
            int min = 0;
            int temp = 0;
            for(int i = 0; i < size; i ++)
            {
                for(int j = i; j > 0; j--)
                {
                    if(a[j] < a[j-1])
                    {
                        temp = a[j-1];
                        a[j-1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            
            for(int i =0; i < size; i++)
            {
                Console.WriteLine(a[i]);
            }  
        }
    }
}
