using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ConvertUtils
    {

        public static MyQueue StringToMyQueue(string s)
        {
            MyQueue queue = new MyQueue();
            string[] arr = s.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mass = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                queue.InQueue(Convert.ToDouble(arr[i]));
            }
            return queue;
        }
        public static string MyQueueToString(MyQueue q)
        {
            string s = Convert.ToString(q.OutQueue());
            while (!q.QueueIsEmpty())
            {
                s += "\r\n" + Convert.ToString(q.OutQueue());
            }
            return s;
        }
    }
}
