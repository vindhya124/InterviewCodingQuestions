using System;
using System.Runtime.Serialization.Json;

namespace InterviewCodingQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var inputArray = new int[] {10, 20, 30, 40, 50};
            ReverseArray(inputArray);

            foreach (var test in GetTestCases())
            {
                var result = Anagram.IsAnagramPair(test.First, test.Second);
                Console.WriteLine((result == test.Expected) ? "Success" : "FAIL");
            }
        }

        private static void ReverseArray(int[] inputArray)
        {
            foreach (var item in inputArray) Console.WriteLine($"Before reversing array {item}");
            int temp;
            int i = 0;
            int j = inputArray.Length - 1;
            while (i < j)
            {
                temp = inputArray[j];
                inputArray[j] = inputArray[i];
                inputArray[i] = temp;
                i++;
                j--;

            }
            foreach (var item in inputArray) Console.WriteLine($"After reversing array {item}");
        }
        public static IEnumerable<TestCase> GetTestCases()
        {
            yield return new TestCase { First = "add", Second = "dad", Expected = true };
            yield return new TestCase { First = "aad", Second = "dad", Expected = false };
            yield return new TestCase { First = "Astronomer", Second = "Moon starer", Expected = true };
            yield return new TestCase { First = "thorough", Second = "through", Expected = false };
            yield return new TestCase { First = "Jim Morrison", Second = "Mr. Mojo Risin'", Expected = true };
        }
    }
}
