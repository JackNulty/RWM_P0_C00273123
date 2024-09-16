using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tests
{
    public class RemoveOddNumbersFilterTest
    {
        [Test]
        public void RemoveOddNumbersFilterSimple()
        {
            int[] input = { 1,2,4,5,8 };
            int[] output = RemoveOddNumbersFilter.RemoveOddNumbers(input);
            int[] expected = { 2,4,8};

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

