using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class HashtableTests
    {
        [Fact]
        public void SettingKey()
        {
            MyHashtable<string> hashtable = new MyHashtable<string>(100);
            hashtable.Set("Mark", "male");
            hashtable.Set("Sarah", "female");

            Assert.NotNull(hashtable);

        }

        [Fact]
        public void Retriveing()
        {
            MyHashtable<string> hashtable = new MyHashtable<string>(100);
            hashtable.Set("Mark", "male");
            hashtable.Set("Sarah", "female");

            Assert.Equal("male", hashtable.Get("Mark"));
        }


        [Fact]
        public void NotExisted()
        {
            MyHashtable<string> hashtable = new MyHashtable<string>(100);
            hashtable.Set("Mark", "male");
            hashtable.Set("Sarah", "female");

            try
            {
                hashtable.Get("suzy");

            }
            catch(ArgumentOutOfRangeException e)
            {
                Assert.Equal("The key suzy is not found! (Parameter 'key')", e.Message);
            }
        }
    }
}
