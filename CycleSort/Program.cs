using System;
using System.Diagnostics;

namespace CycleSort
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

                  CycleSort(inputIntegers);

                  // End recording runtime
                  watch.Stop();

                  Console.WriteLine("Sorted List: ");

                  PrintSortedArray(CycleSort(inputIntegers));

                  // Print to the console the runtime in milliseconds
                  Console.WriteLine($"\nExecution Time: {watch.ElapsedMilliseconds} ms");
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

