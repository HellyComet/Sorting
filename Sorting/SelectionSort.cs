using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] a, int n)
        {
            int minIndex, temp, i, j;
            
            for(i = 0; i < n -1; i++) //Pass or iterations
            {
                minIndex = i; // First Pass : a[0]

                for(j = i + 1; j < n; j++)
                {
                    if(a[j] < a[minIndex])
                        minIndex = j;
                }
                if( i!= minIndex)
                {
                    temp = a[i];
                    a[i] = a[minIndex];
                    a[minIndex] = temp;
                }
            }
        }
        public static void Main(string[] args)
        {
            int i, n;

            int[] a = new int[20];

            Console.WriteLine("Enter the number of elements");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element at:" + a[i] + "positon");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Sort(a, n);

            Console.WriteLine("Sorted array");
            for (i = 0; i < n; i++)
                Console.WriteLine(a[i] + "");
            Console.WriteLine();
        }

    }
}
