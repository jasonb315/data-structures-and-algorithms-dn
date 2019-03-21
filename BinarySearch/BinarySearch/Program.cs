using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
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

            foreach(int i in arr)
            {
                Console.WriteLine("Enter sorted array values");
                string iStr = Console.ReadLine();
                int iVal = Convert.ToInt32(inputStr);
                arr[i] = iVal;
            }

            Console.WriteLine("Enter search key");
            string keyStr = Console.ReadLine();
            int keyVal = Convert.ToInt32(inputStr);
            int key = arrLen;

            int iReturn = BinarySearch(arr, key);
            Console.WriteLine(iReturn);

        }
        static int BinarySearch(int[]arr, int key)
        {
            int min = 0;
            int max = arr.Length - 1;
            int mid = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;

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
