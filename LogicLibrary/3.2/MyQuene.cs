using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class MyQueue
    {
        public Node Head { get; set; }                            // голова 
        public Node Tail { get; set; }
        public int Count { get; set; }                       // число элементов
                                                             //  public MyQueue Queue { get; set; }

        public MyQueue()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool QueueIsEmpty()              // проверка на пустоту
        {
            return Head == null;
        }

        public void InQueue(double inf)            // положить в хвост очереди
        {
            Node p = new Node() { Inf = inf, Next = null };
            if (QueueIsEmpty())
            {
                Head = p;
                Tail = p;
            }
            else
            {
                Tail.Next = p;
                Tail = p;
            }
            Count++;
        }

        public double OutQueue()                   // взять из головы очереди
        {
            Node p = Head;
            Head = Head.Next;
            Count--;
            return p.Inf;
        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            Node p = Head;
            while (p != null)
            {
                Array.Resize<string>(ref st, ++L);
                st[L - 1] = p.Inf.ToString();
                p = p.Next;
            }
            return st;
        }

        public void RemoveSameItem()
        {
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Inf == current.Next.Inf)
                    current.Next = current.Next.Next;
                else
                    current = current.Next;
            }
        }


        public void AddPositiveItemAfterNegative()
        {
            Node current = Head;
            while (current.Next != null)
            {
                if (current.Inf < 0)
                {
                    Node newNode = new Node { Inf = Math.Abs(current.Inf), Next = current.Next };
                    current.Next = newNode;
                }
                current = current.Next;
            }
        }
    }
}