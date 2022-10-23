using System;
using System.Diagnostics;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] inputIntegers = {74, 87, 83, 48, 34, 53, 86, 65, 84, 63, 77, 12, 85, 99, 15, 51, 0, 54, 26, 60};

            watch.Start();



            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            Console.WriteLine("Sorted List: ");
        }

        public int[] BubbleSort(int[] inputArray)
        {
            bool isSorted = false;

            while (isSorted == false)
            {
                for (int counter = 0 ; counter < inputArray.Length - 1 ; counter++)
                {

                }
            }
        }
    }
}