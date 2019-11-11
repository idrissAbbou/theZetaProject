using System;
using System.Collections;
using System.Collections.Generic;
using MyClasses;
using Day2;

namespace theZetaProject
{
    public delegate bool del(int i);
    class Program
    {        
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,5,7,9,4,3,6};
            IEnumerable<int> result = arr.ReturnBasedOnFilter(i=> i%2 ==0);
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }

            day2.VirtualMain();
        }
    }

    public static class HelperArray {
        public static IEnumerable<int> ReturnBasedOnFilter(this IEnumerable<int> args, Func<int, bool> filter) {
            foreach (var item in args)
            {
                if (filter(item))
                {
                    yield return item;
                }
            }
        }
    }
}

