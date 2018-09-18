using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Sort
    {
        public void GetCountCompareExchange(int[] countItems, out int[] countExchange, out int[] countCompare)
        {
            countExchange = new int[countItems.Length];
            countCompare = new int[countItems.Length];
            int k = 0;
            foreach (int i in countItems)
            {
                int[] arr = new int[i];
                Random r = new Random();
                for (int j = 0; j < i; j++)
                    arr[j] = r.Next(-1000, 1000);
                int countEx, countCom;
                CombSort(arr, out countEx, out countCom);
                countExchange[k] = countEx;
                countCompare[k] = countCom;
                k++;
            }

        }

        void CombSort(int[] input, out int countExchange, out int countCompare)
        {

            countCompare = countExchange = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    countCompare++;
                    if (input[i] > input[j])
                    {

                        Swap(ref input[i], ref input[j]);
                        countExchange++;
                    }
                }
            }

        }

        void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val2;
            val2 = val1;
            val1 = temp;
        }
    }
}