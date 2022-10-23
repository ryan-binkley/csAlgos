using System;
using System.Diagnostics;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] inputIntegers = GenerateRandomIntegerArray(100000);

            watch.Start();

            BubbleSort(inputIntegers);

            watch.Stop();

            Console.WriteLine("Sorted List: ");

            PrintSortedArray(BubbleSort(inputIntegers));

            Console.WriteLine($"\nExecution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static int[] BubbleSort(int[] inputArray)
        {
            int tempInt;

            for (int counter1 = 0 ; counter1 < inputArray.Length ; counter1++)
            {
                for (int counter2 = 0 ; counter2 < inputArray.Length - 1 ; counter2++)
                {
                    if (inputArray[counter2] > inputArray[counter2 + 1])
                    {
                        tempInt = inputArray[counter2 + 1];

                        inputArray[counter2 + 1] = inputArray[counter2];

                        inputArray[counter2] = tempInt;
                    } 
                }
            }

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