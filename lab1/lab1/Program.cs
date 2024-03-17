using System;

namespace lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 2, 3, 4, 5 };


            Console.Write("mod1\n");
            Console.Write("mod2.\n");
            Console.Write("mod3.\n");
            
            program.sumAverageElements(arr);

        }

        public void sumAverageElements(int[] arr)
        {
            int size = arr.Length;
            int sum = 0;
            int avg = 0;

            for (int j = 0; j < size; j++)
            {
                sum += arr[j];
            }

            avg = sum / size;

            Console.WriteLine("The Sum 0f array: " + sum);
            Console.WriteLine("The Average 0f array: " + avg);
        }
    }
}