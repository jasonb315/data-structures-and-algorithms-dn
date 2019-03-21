using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int BinarySearch(int[]arr, int key)
        {
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max)
            {
                double x = (min + max) / 2;
                int mid = (int)Math.Floor(x);

                if (arr[mid] < key)
                {
                    min = mid + 1;
                }
                else if (arr[mid] > key)
                {
                    max = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
