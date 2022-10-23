using System;
using System.Diagnostics;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diagnostics has a built in timer for recording execution time
            var watch = new System.Diagnostics.Stopwatch();

            // Generate an unsorted array of x numbers
            int[] inputIntegers = GenerateRandomIntegerArray(100000);

            // Begin recording runtime
            watch.Start();

            BubbleSort(inputIntegers);

            // End recording runtime
            watch.Stop();

            Console.WriteLine("Sorted List: ");

            PrintSortedArray(BubbleSort(inputIntegers));

            // Print to the console the runtime in milliseconds
            Console.WriteLine($"\nExecution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static int[] BubbleSort(int[] inputArray)
        {
            // Create a buffer to move around the one int we are sorting
            int tempInt;

            // Iterate through the array for every single integer in the array
            for (int counter1 = 0 ; counter1 < inputArray.Length ; counter1++)
            {
                // Iterate and check each integers next neighbor to see if a swap is necessary
                for (int counter2 = 0 ; counter2 < inputArray.Length - 1 ; counter2++)
                {
                    if (inputArray[counter2] > inputArray[counter2 + 1])
                    {
                        // If swap is necessary, put the neighboring integer into the buffer
                        tempInt = inputArray[counter2 + 1];

                        // Set the neighbor to the current integer
                        inputArray[counter2 + 1] = inputArray[counter2];

                        // Set original integer to the integer in the buffer
                        inputArray[counter2] = tempInt;
                    } 
                }
            }
            // Return the sorted inputArray
            return inputArray;
        }

        public static void PrintSortedArray(int[] inputArray)
        {
            foreach (int x in inputArray)
            {
                Console.Write(x.ToString() + " ");
            }
        }

        public static int[] GenerateRandomIntegerArray(int arrayLength)
        {
            Random rng = new Random();

            int[] randomIntegers = new int[arrayLength];

            for (int i = 0 ; i < randomIntegers.Length ; i++)
            {
                randomIntegers[i] = rng.Next(1, 100);
            }

            return randomIntegers;
        }
    }
}