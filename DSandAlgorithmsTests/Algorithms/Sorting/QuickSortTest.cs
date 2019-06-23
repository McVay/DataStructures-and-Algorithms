﻿using DSandAlgorithms.Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSandAlgorithmsTests.Algorithms.Sorting
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            var input = new int[] { 40, 34, 500, 100, 43, 43, 65 };
            var sorted = input.OrderBy(s => s).ToList();

            QuickSort.Sort(input);

            CollectionAssert.AreEqual(input, sorted);
            Assert.AreEqual(500, input[input.Length - 1]);
        }
    }
}