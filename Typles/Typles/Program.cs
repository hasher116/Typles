using System;

namespace Typles
{
    class Program
    {
        static void Main(string[] args)
        {
            var Values = GetValues();
            Console.WriteLine($"{Values.Item1}, {Values.Item2}");

            var massive = Array(new int[] { 2, 6, 8, 1, 4, 3 });
            Console.WriteLine($"{massive.Item1}, {massive.Item2}");
        }

        static (int, int) GetValues()
        {
            var result = (1, 3);
            return result;
        }

        static (int, int) Array(int [] numbers)
        {
            var result = (count:0, sum:0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.count = numbers.Length;
                result.sum += numbers[i];
            }
            return result;
        }
    }
}
