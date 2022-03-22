using System;

namespace Algothm_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = new int[5]{ 1, 2, 3, 4, 5 };
            var soln = SortArray(intArray);
            Console.WriteLine(soln);
        }

        static int SortArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }

            var result = 0;
            foreach (var number in arr)
            {
                if (number == 8)
                {
                    result += 5;
                    continue;
                }
                else if (number % 2 == 0)
                {
                    result += 1;
                }
                else if (number % 2 == 1)
                {
                    result += 3;
                }
                continue;
            }
            return result;
        }
    }
}
