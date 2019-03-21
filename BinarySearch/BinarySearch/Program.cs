using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string appName = "ATM";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Enter array length");
            string inputStr = Console.ReadLine();
            int arrLen = Convert.ToInt32(inputStr);
            int[] arr = new int[arrLen];

            Console.WriteLine("Enter sorted array values one at a time");
            for (int i = 0; i < arr.Length; i++)
            {
                string iStr = Console.ReadLine();
                int iVal = Convert.ToInt32(iStr);
                arr[i] = iVal;
                //Console.WriteLine($"arr[i]{arr[i]}");
            }

            Console.WriteLine("Enter search key");
            string keyStr = Console.ReadLine();
            int key = Convert.ToInt32(keyStr);

            int iReturn = BinarySearch(arr, key);
            Console.WriteLine($"F(x) returns: {iReturn}");

        }
        /// <summary>
        ///     Log n search for array index of given search key
        /// </summary>
        /// <param name="arr">int arr</param>
        /// <param name="key">int key</param>
        /// <returns>int index or -1</returns>
        public static int BinarySearch(int[] arr, int key)
        {
            int min = 0;
            int max = arr.Length - 1;
            int mid = (min + max) / 2;

            //Console.WriteLine($"ini min {min}");
            //Console.WriteLine($"ini mid {mid}");
            //Console.WriteLine($"ini max {max}");

            if (arr[min] == key)
            {
                return min;
            }
            if (arr[max] == key)
            {
                return max;
            }

            while (min <= max)
            {
                mid = (min + max) / 2;
                //Console.WriteLine($"while mid {mid}");

                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }
    }
}
