﻿using SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithmTest
{
    public partial class SelectionSortTests
    {
        [Fact]
        public void SelectionSort_Test()
        {
            var arr = new char[] { 'a', 'd', 'z', 'c' };
            SelectionSort.Sort(arr);

            Assert.Collection(arr,
                    item => Assert.Equal('a', item),
                    item => Assert.Equal('c', item),
                    item => Assert.Equal('d', item),
                    item => Assert.Equal('z', item));
        }

        [Fact]
        public void SortDirection_SelectionSort_Test()
        {

            var arr = new char[] { 'a', 'd', 'z', 'c' };
            SelectionSort.Sort(arr, Utilities.SortDirection.Descending);

            Assert.Collection(arr,
                    item => Assert.Equal('z', item),
                    item => Assert.Equal('d', item),
                    item => Assert.Equal('c', item),
                    item => Assert.Equal('a', item));

        }
    }
}
