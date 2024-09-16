using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOddNumbersFilter
{
    public static bool checkNumberOdd(int input)
    {
        if (input % 2 == 0)
        {
            return true;
        }
        else return false;
    }

    public static int[] RemoveOddNumbers(int[] array)
    {
        List<int> outputList = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (checkNumberOdd(array[i]) == true)
            {
                outputList.Add(array[i]);
            }
        }

        return outputList.ToArray();
    }
}
