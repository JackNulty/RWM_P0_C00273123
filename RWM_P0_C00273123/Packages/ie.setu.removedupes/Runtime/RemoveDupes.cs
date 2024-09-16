using Codice.Client.Common;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RemoveDupes
{
    void Start()
    {
        int[] arrayDupes = { 1,2,3,4,5,6,4,2,4,7,8,8,6 };

        int [] arrayNoDupes = Remove(arrayDupes);
    }

    public static int[] Remove(int[] array)
    {
        HashSet<int> uniqueValues = new HashSet<int>(array);

        return uniqueValues.ToArray();
    }
}
