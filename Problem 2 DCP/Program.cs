using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Problem_2_DCP
{
    class Program
    {
        /// <summary>
        /// This problem was asked by Uber.
        /// Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
        /// For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be[2, 3, 6].
        /// Follow-up: what if you can't use division?
        /// </summary>
        ///
        /// iterate through the array
        /// let first index of the array be i be value1
        /// let index j be the one next to index i, be value2
        /// 

        public static int[] arrayProduct(int[] arr)
        {
            int[] returnArray = new int[arr.Length];
            int total=1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j != i)
                    {
                        total = total * arr[j];
                    }
                }

                returnArray[i] = total;
                total = 1;
            }

            return returnArray;
        }

    public static void Main()
        {
            int[] arr = {1, 2, 3, 4, 5};
            int[] arr1 = {3, 2, 1};

            int[] solution = arrayProduct(arr);
            int[] solution1 = arrayProduct(arr1);


            foreach (var i in solution)
            {
                Console.WriteLine(i);
            }

            foreach (var i in solution1)
            {
                Console.WriteLine(i);
            }



        }
    }
}
