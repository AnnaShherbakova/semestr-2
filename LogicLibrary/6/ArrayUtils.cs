using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicLibrary
{
    public class ArrayUtils
    {
        public static int[] StrToInt(string[] arr)
        {
            int[] s = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                s[i] = Convert.ToInt32(arr[i]) - 1;
            }
            return s;
        }

        public static List<int> ArrToList(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (int a in arr)
            {
                list.Add(a);
            }
            return list;
        }
    }
}