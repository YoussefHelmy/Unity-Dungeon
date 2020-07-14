using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extension
{

    public static string ReplaceCharToString(this string original, int index , char c)
    {
        char[] arr = new char[original.Length];
        arr = original.ToCharArray(); ;
        arr[index] = c;
        original = new string(arr);
        return original;
    }
}
   

