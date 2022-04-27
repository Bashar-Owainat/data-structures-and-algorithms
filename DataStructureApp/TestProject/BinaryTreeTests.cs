﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureApp;
using Xunit;

namespace TestProject
{
    public class BinaryTreeTests
    {
        [Fact]
        public void InstantiateEmptyBT()
        {
            MyBinarySearchTree Bt = new MyBinarySearchTree();
            Assert.Null(Bt.root);

        }

        [Fact]
        public void SingleRoot()
        {
            MyBinarySearchTree Bt = new MyBinarySearchTree();
            Bt.Add(3);
            Assert.Equal(3, Bt.root.value);

        }

        [Fact]
        public void AddLeftRight()
        {
            MyBinarySearchTree Bt = new MyBinarySearchTree();
            Bt.Add(5);
            Bt.Add(3);
            Bt.Add(6);

            Assert.Equal(3, Bt.root.leftNode.value);
            Assert.Equal(6, Bt.root.rightNode.value);

        }

        [Fact]
        public void TestPreOrder()
        {
            MyBinarySearchTree Bt = new MyBinarySearchTree();
            Bt.Add(5);
            Bt.Add(10);
            Bt.Add(3);
            Bt.Add(7);
            //5
            // 3
            //10
            //7
            List<int> test = new List<int>();
            test.Add(5);
            test.Add(3);
            test.Add(10);
            test.Add(7);

            Assert.Equal(test, Bt.TraversePreOrder(Bt.root));




        }

       




        

       
    }
}
