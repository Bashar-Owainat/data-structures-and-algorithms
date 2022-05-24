using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureApp;
using Xunit;
namespace TestProject
{
    public class InsertionSortTest
    {

        [Fact]
        public void TestValidSorting()
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] sorted = { 4, 8, 15, 16 , 23, 42 };

            int[] result = Program.InsertionSort(arr);
            Assert.Equal(result, sorted);
        }

        [Fact]
        public void TestInValidSorting()
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] Notsorted = { 8, 4 , 15, 16, 23, 42 };

            int[] result = Program.InsertionSort(arr);
            Assert.NotEqual(result, Notsorted);
        }
    }
}
