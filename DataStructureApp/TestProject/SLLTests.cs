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

            Assert.Null(list.head);
        }

        [Fact]
        public void Insert()
        {
            SLL list = new SLL();
            list.Insert(8);

            Assert.Equal(8, list.head.value);
        }

        [Fact]
        public void PointAtHead()
        {
            SLL list = new SLL();
            list.Insert( 8);
            list.Insert(10);
            list.Insert( 1);
            list.Insert( 2);

            Assert.Equal(2, list.head.value);

        }

        [Fact]
        public void InsertMultipleNodes()
        {

            SLL list = new SLL();
            list.Insert( 8);
            list.Insert( 10);
            list.Insert( 1);
            list.Insert( 2);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[2] -> [1] -> [10] -> [8] -> NUll", result);

        }

        [Fact]
        public void FindValue()
        {
            SLL list = new SLL();
            list.Insert( 8);
            list.Insert( 10);
            list.Insert( 1);
            list.Insert( 2);

            Assert.True(SLL.Includes(list, 10));

        }

        [Fact]
        public void ValueNotFound()
        {
            SLL list = new SLL();
            list.Insert( 8);
            list.Insert(10);
            list.Insert( 1);
            list.Insert(2);

            Assert.False(SLL.Includes(list, 100));

        }

        [Fact]
        public void RetunValues()
        {

            SLL list = new SLL();
            list.Insert( 8);
            list.Insert( 7);
            list.Insert( 6);
            list.Insert( 5);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[5] -> [6] -> [7] -> [8] -> NUll", result);

        }





        //tests for challenge 6

        [Fact]
        public void AppendOneNode()
        {
            SLL list = new SLL();
            list.Append( 5);
            list.Append( 2);
            list.Append(6);
            string result = SLL.ToStringMethod(list);
            Assert.Equal("[2] -> [5] -> [6] -> NUll", result);
        }

        [Fact]
        public void AppendMultipleNodes()
        {
            SLL list = new SLL();
            list.Append(5);
            list.Append(2);
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
            list.Insert(5);
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
            list.Insert(5);
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
            list.Insert(5);
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
            list.Insert(5);
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
            list.Append( 5);
            list.Append(2);
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
            list.Insert(5); // it adds at head
            list.Insert(2); // it adds at head
            list.Append(6); // it adds at the end


            Assert.Equal(2, list.KthFromEnd(3));

        }


        [Fact]
        public void NegativeNumbers()
        {
            SLL list = new SLL();
            list.Insert( 5); // it adds at head
            list.Insert(2); // it adds at head
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
            list.Insert( 5); // it adds at head



            Assert.Equal(5, list.KthFromEnd(1));



        }



        [Fact]
        public void NumberInMiddle()
        {
            SLL list = new SLL();
            list.Insert( 5); // it adds at head
            list.Append(8);
            list.Append(2);
            list.Append(3);
            list.Append(7);
            list.Append(6);
            list.Append(4);

            Assert.Equal(3, list.KthFromEnd(4));



        }

        [Fact]
        public void ZipList()
        {
            SLL list1 = new SLL();
            SLL list2 = new SLL();

            list1.Append(9);
            list1.Append(6);
            list1.Append(3);
            list2.Append(8);
            list2.Append(4);
            list2.Append(2);

            SLL newList = new SLL();
            newList =  SLL.ZipList(list1, list2);
           
            Assert.Equal("[9] -> [8] -> [6] -> [4] -> [3] -> [2] -> NUll", SLL.ToStringMethod(newList)); 


        }
    }
}

