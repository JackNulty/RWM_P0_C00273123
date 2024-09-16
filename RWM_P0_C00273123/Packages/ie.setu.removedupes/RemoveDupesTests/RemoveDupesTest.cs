using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class RemoveDupesTest
{
    [Test]
    public void RemoveDupesTestSimplePasses()
    {
        int[] input = { 1, 2, 3, 4, 5, 6, 4, 2, 4, 7, 8, 8, 6 };
        int[] output = RemoveDupes.Remove(input);
        int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };

        CollectionAssert.AreEqual(expected, output);
    }

}
