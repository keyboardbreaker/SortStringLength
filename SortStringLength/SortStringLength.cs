using System;
using System.Collections.Generic;

namespace SortStringLength
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] unsorted = new string[]{ "betty", "adam", "ray" };
            Console.WriteLine("List unsorted: ");
            foreach (string item in unsorted)
                Console.WriteLine(item);

            Console.WriteLine("List Sorted");
            Array.Sort(unsorted, (x, y) => 
                            x.Length.CompareTo(y.Length));
            foreach (string name in unsorted)
                Console.WriteLine(name);
        }
    }
}
