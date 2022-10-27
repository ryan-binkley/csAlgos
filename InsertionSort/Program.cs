using System;
using System.Diagnostics;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diagnostics has a built in timer for recording execution time
            var watch = new System.Diagnostics.Stopwatch();

            // Generate an unsorted array of x numbers
            int[] inputIntegers = GenerateRandomIntegerArray(10000);

            // Begin recording runtime
            watch.Start();

            InsertionSort(inputIntegers);

            // End recording runtime
            watch.Stop();

            Console.WriteLine("Sorted List: ");

            PrintSortedArray(InsertionSort(inputIntegers));

            // Print to the console the runtime in milliseconds
            Console.WriteLine($"\nExecution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static int[] InsertionSort(int[] inputArray)
        {
            // Compare the first two elements - if they are not in the correct order, swap them and put them in a 'sorted' sub-array, if they are in the correct order, no swap is needed
            // Compare each element with the one in front of it, if the first element is greater than the second, swap them, then compare the swapped number with the next number in the sub-array going down recursively
            int placeholder;
            int positionToTheLeft;

            // For every element in the input array except the last, perform below statements
            for (int i = 0 ; i < inputArray.Length ; i++)
            {
                // placeholder holds the current value
                placeholder = inputArray[i];

                // positionToTheLeft is just i - 1, so -1 at the start
                positionToTheLeft = i - 1;

                // While positionToTheLeft is greater than or equal to 0 AND the value at the index of positionToTheLeft is greater than the value of the current index, perform statements below
                while (positionToTheLeft >= 0 && inputArray[positionToTheLeft] > placeholder)
                {
                    // Set the current element to the element to it's left
                    inputArray[positionToTheLeft + 1] = inputArray[positionToTheLeft];
                    
                    // Move positionToTheLeft back one element and do the while loop statements until positionToTheLeft is -1 OR the current value is greater than the positionToTheLeft
                    positionToTheLeft = positionToTheLeft - 1;
                }
                // Set the final positionToTheLeft + 1, to the placeholder, whose value at index was just erased in the while loop
                inputArray[positionToTheLeft + 1] = placeholder;
            }

            // Returns the modified array
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
