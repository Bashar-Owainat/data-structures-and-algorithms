using DataStucture.LinkedList;
using System;
using Xunit;

namespace TestProject
{
    public class SLLTests
    {
        [Fact]
        public void EmptyInstantiation()
        {
            SLL list = new SLL();

            Assert.Equal(null, list.head);
        }

        [Fact]
        public void Insert()
        {
            SLL list = new SLL();
            SLL.Insert(list, 8);

            Assert.Equal(8, list.head.value);
        }

        [Fact]
        public void PointAtHead()
        {
            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 10);
            SLL.Insert(list, 1);
            SLL.Insert(list, 2);

            Assert.Equal(2, list.head.value);

        }

        [Fact]
        public void InsertMultipleNodes()
        {

            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 10);
            SLL.Insert(list, 1);
            SLL.Insert(list, 2);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[2] -> [1] -> [10] -> [8] -> NUll", result);

        }

        [Fact]
        public void FindValue()
        {
            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 10);
            SLL.Insert(list, 1);
            SLL.Insert(list, 2);

            Assert.Equal(true, SLL.Includes(list, 10));

        }

        [Fact]
        public void ValueNotFound()
        {
            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 10);
            SLL.Insert(list, 1);
            SLL.Insert(list, 2);

            Assert.Equal(false, SLL.Includes(list, 100));

        }

        [Fact]
        public void RetunValues()
        {

            SLL list = new SLL();
            SLL.Insert(list, 8);
            SLL.Insert(list, 7);
            SLL.Insert(list, 6);
            SLL.Insert(list, 5);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[5] -> [6] -> [7] -> [8] -> NUll", result);

        }





        //tests for challenge 6

        [Fact]
        public void AppendOneNode()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            SLL.Insert(list, 2);
            list.Append(6);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[2] -> [5] -> [6] -> NUll", result);
        }

        [Fact]
        public void AppendMultipleNodes()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            SLL.Insert(list, 2);
            list.Append(6);
            list.Append(6);
            list.Append(6);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[2] -> [5] -> [6] -> [6] -> [6] -> NUll", result);

            //[2] -> [5] -> [6] -> [6] -> [6] -> NUll

        }


        [Fact]
        public void InsertBefore()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            list.Append(6);
            list.Append(5);

            Node givenNode = list.head.next;
            list.InsertBefore(givenNode, 9);

            //[5] -> [6] -> [5] -> NUll
            Assert.Equal("[5] -> [9] -> [6] -> [5] -> NUll", SLL.ToStringMethod(list));
        }

        [Fact]
        public void InsertBeforeFirst()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            list.Append(6);
            list.Append(5);

            Node givenNode = list.head;
            list.InsertBefore(givenNode, 9);


            Assert.Equal("[9] -> [5] -> [6] -> [5] -> NUll", SLL.ToStringMethod(list));
        }

        [Fact]
        public void InsertAfter()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            list.Append(6);
            list.Append(5);

            Node givenNode = list.head.next;
            list.InsertAfter(givenNode, 8);

            Assert.Equal("[5] -> [6] -> [8] -> [5] -> NUll", SLL.ToStringMethod(list));
        }

        [Fact]
        public void InsertAfterLast()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            list.Append(6);
            list.Append(5);

            Node givenNode = list.head.next.next;
            list.InsertAfter(givenNode, 8);

            Assert.Equal("[5] -> [6] -> [5] -> [8] -> NUll", SLL.ToStringMethod(list));
        }






        // tests for challenge 7


        [Fact]
        public void KOutOfRange()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5);
            SLL.Insert(list, 2);
            list.Append(6);
            try
            {

                list.KthFromEnd(4);

            }
            catch (IndexOutOfRangeException e)
            {


                Assert.Equal("4 is out of the linked list's range! ", e.Message);

            }


        }


        [Fact]
        public void SameNumbers()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5); // it adds at head
            SLL.Insert(list, 2); // it adds at head
            list.Append(6); // it adds at the end


            Assert.Equal(2, list.KthFromEnd(3));

        }


        [Fact]
        public void NegativeNumbers()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5); // it adds at head
            SLL.Insert(list, 2); // it adds at head
            list.Append(6); // it adds at the end

            try
            {

                list.KthFromEnd(-3);
            }
            catch (ArgumentException e)
            {
                Assert.Equal("Invalid input! You cannot enter a number less than 1", e.Message);

            }



        }

        [Fact]
        public void OneNumber()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5); // it adds at head



            Assert.Equal(5, list.KthFromEnd(1));



        }



        [Fact]
        public void NumberInMiddle()
        {
            SLL list = new SLL();
            SLL.Insert(list, 5); // it adds at head
            list.Append(8);
            list.Append(2);
            list.Append(3);
            list.Append(7);
            list.Append(6);
            list.Append(4);

            Assert.Equal(3, list.KthFromEnd(4));



        }
    }
}

