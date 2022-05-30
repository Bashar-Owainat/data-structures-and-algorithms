using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructureApp;


namespace TestProject
{
    public class QuickSortTests
    {
        [Fact]
        public void ValidTest()
        {
            int[] arr = { 50, 12, 30, 3, 21, 8 };
           int[] result =  Program.QuickSort(arr, 0, 5);

            int[] sorted = { 3, 8, 12, 21, 30, 50 };

            Assert.Equal(result, sorted);
        }

        [Fact]
        public void InValidTest()
        {
            int[] arr = { 50, 12, 30, 3, 21, 8 };
            int[] result = Program.QuickSort(arr, 0, 5);

            int[] NotSorted = {  12, 21, 30, 50, 3, 8};

            Assert.NotEqual(result, NotSorted);
        }
    }
}
