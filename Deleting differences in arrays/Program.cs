using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Your goal in this kata is to implement a difference function, which subtracts one list 
 * from another and returns the result.
 * It should remove all values from list a, which are present in list b keeping their order.
 * =>  Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
 * 
 * If a value is present in b, all of its occurrences must be removed from the other:
 * Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
 */

namespace Deleting_differences_in_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = new int[] {1, 2}; //array with numbers thats gonna be deleted
            int[] niz2 = new int[] {2, 2, 3}; //insert numbers that  you want to delete

            int[] niz3 = ArrayDiff(niz1, niz2);

            foreach (var item in niz3)
            {

            }

            int[] ArrayDiff(int[] a, int[] b)
            {
                List<int> arr1 = a.ToList();
                List<int> arr2 = b.ToList();

                foreach (var item in arr1) arr2.RemoveAll(x => x == item);

                return arr2.ToArray();
            }
        }
    }
}





