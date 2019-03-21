using System;
using Xunit;
using BinarySearch;


namespace BinarySearchTest
{
    public class UnitTests
    {
        [Fact]
        public void Test1()
        {
            int[] arr = new int[] { 4, 5, 6, 7, 8 };
            int x = Program.BinarySearch(arr, 6);
            Assert.Equal(2, x);
        }

        [Fact]
        public void Test2()
        {
            int[] arr = new int[] { 4, 5, 6, 7, 8 };
            int x = Program.BinarySearch(arr, 5);
            Assert.Equal(1, x);
        }

        [Fact]
        public void Test3()
        {
            int[] arr = new int[] { 4, 5, 6, 7, 8 };
            int x = Program.BinarySearch(arr, 8);
            Assert.Equal(4, x);
        }

        [Theory]
        [InlineData(4, 0)]
        [InlineData(5, 1)]
        [InlineData(6, 2)]
        [InlineData(7, 3)]
        [InlineData(8, 4)]

        public void Test4(int a, int b)
        {
            int[] arr = new int[] { 4, 5, 6, 7, 8 };
            int x = Program.BinarySearch(arr, a);
            Assert.Equal(b, x);
        }
    }
}
