using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Alogorithms
{
    public class SelectionSort
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Selection Sort !");
            int size = Convert.ToInt16(Console.ReadLine());
            Console.Write(size);
            int [] a = new int[size];
            for (int i =0; i < size; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            
            // selection sort
            int min = 0;
            int temp = 0;
            for(int i = 0; i < size; i ++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if(a[j] < a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
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
