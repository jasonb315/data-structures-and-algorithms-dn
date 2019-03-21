using System;
using Xunit;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arr = new int[] { 4, 5, 6, 7, 8 };
            int x = BinarySearch(arr, 6);
            Assert.Equal(2, x);
        }
    }
}
