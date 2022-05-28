using DataStructureApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
   public class MergeSortTests
    {

        [Fact]
        public void ValidMergeSort()
        {
            int[] arr = { 8, 4 ,23 ,42 ,16, 15};

            int[] result = Program.SortArray(arr, 0, 5);

            int[] sorted = { 4, 8, 15, 16, 23, 42};


            Assert.Equal(result, sorted);
        }

        [Fact]
        public void InValidMergeSort()
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };

            int[] result = Program.SortArray(arr, 0, 5);

            int[] NotSorted = { 15, 16, 23, 42 , 4, 8, };


            Assert.NotEqual(result, NotSorted);
        }
    }
}
