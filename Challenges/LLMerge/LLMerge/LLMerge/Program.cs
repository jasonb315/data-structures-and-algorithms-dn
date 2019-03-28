using System;
using LinkedList.Classes;

namespace LLMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static Node LLMerge(SinglyLinkedList A, SinglyLinkedList B)
        {
            try
            {
                Node A1 = A.Head;
                Node B1 = B.Head;

                if (A1 == null && B1 == null)
                {
                    return null;
                }
                if (A1 == null && B1 != null)
                {
                    return B1;
                }
                if(A1 != null && B1 == null)
                {
                    return A1;
                }

                Node A2 = A1.Next;
                Node B2 = B1.Next;

                if (A2 == null && B2 != null)
                {
                    A1.Next = B1;
                    return A1;
                }
                if(A2 != null && B2 == null)
                {
                    A1.Next = B1;
                    B1.Next = A2;
                    return A1;
                }
                while(A2 != null && B2 != null)
                {
                    A1.Next = B1;
                    B1.Next = A2;
                    A1 = A2;
                    B1 = B2;
                    A2 = A2.Next;
                    B2 = B2.Next;
                    
                }
                if(A2 != null && B2 == null)
                {
                    A1.Next = B1;
                    B1.Next = A2;
                    return A.Head;
                }
                if(A2 == null && B2 != null)
                {
                    A1.Next = B1;
                    return A.Head;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return A.Head;

        }
    }
}
