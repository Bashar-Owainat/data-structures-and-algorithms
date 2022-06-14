using DataStructureApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
   public class RepeatedWordTests
    {
        [Fact]
        public void ValidResult()
        {
            string test = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

            string result = Program.RepeatedWord(test);

            Assert.Equal("summer", result);
        }


        [Fact]
        public void InValidResult()
        {
            string test = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

            string result = Program.RepeatedWord(test);

            Assert.NotEqual("It", result);
        }
    }


}
