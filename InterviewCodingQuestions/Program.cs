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
    }
}
