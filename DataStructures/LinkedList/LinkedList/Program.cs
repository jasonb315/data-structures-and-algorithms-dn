﻿using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string appName = "LinkedList";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("INSERT");
            InsertDemo();
            Console.WriteLine();

            Console.WriteLine("APPEND");
            AppendDemo();
            Console.WriteLine();


            Console.WriteLine("INCLUDES");
            IncludesDemo();
            Console.WriteLine();

            Console.WriteLine("INSERT AFTER");
            InsertAfterDemo();
            Console.WriteLine();

            Console.WriteLine("INSERT BEFORE");
            InsertBeforeDemo();
            Console.WriteLine();

            Console.WriteLine("KTH FROM END");
            KthFromEndDemo();
            Console.WriteLine();
        }

        static void InsertDemo()
        {
            SinglyLinkedList ll = new SinglyLinkedList();

            ll.Insert(1);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Insert(2);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Insert(3);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Insert(4);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Insert(5);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Insert(6);
            ll.ReadThrough();
            Console.WriteLine();
        }

        static void AppendDemo()
        {
            SinglyLinkedList ll = new SinglyLinkedList();

            ll.Append(1);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Append(2);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Append(3);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Append(4);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Append(5);
            ll.ReadThrough();
            Console.WriteLine();

            ll.Append(6);
            ll.ReadThrough();
            Console.WriteLine();

        }

        static void IncludesDemo()
        {
            SinglyLinkedList ll = new SinglyLinkedList();
            ll.Append(3);
            ll.Append(1);
            ll.Append(5);
            ll.ReadThrough();

            bool pos = ll.Includes(3);
            bool neg = ll.Includes(7);
            Console.WriteLine();
            Console.WriteLine($"3: {pos}");
            Console.WriteLine($"7: {neg}");
        }

        static void InsertBeforeDemo()
        {
            SinglyLinkedList ll = new SinglyLinkedList();
            ll.Append(3);
            ll.Append(1);
            ll.Append(5);
            ll.ReadThrough();
            Console.WriteLine("insert before 1, a 10");
            ll.InsertBeforeVal(1, 10);
            ll.ReadThrough();
            Console.WriteLine();
        }

        static void InsertAfterDemo()
        {
            SinglyLinkedList ll = new SinglyLinkedList();
            ll.Append(3);
            ll.Append(1);
            ll.Append(5);
            ll.ReadThrough();
            Console.WriteLine("insert after 1, a 10");
            ll.InsertAfterVal(1, 10);
            ll.ReadThrough();
            Console.WriteLine();
        }

        static void KthFromEndDemo()
        {
            SinglyLinkedList ll = new SinglyLinkedList();
            ll.Append(3);
            ll.Append(1);
            ll.Append(5);
            ll.ReadThrough();
            int x = ll.KthFromEnd(1);
            Console.WriteLine($"return first from end: {x}");
        }
    }
}
