using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LogicLibrary
{
    public class MyTree
    {
        public NodeTree top;             // вершина дерева
        public NodeTree selectNode { get; set; }      // выделенный узел

        Random rnd { get; set; }


        public MyTree()
        {
            top = null;
            rnd = new Random();
        }

        public int BinarySearch(NodeTree node)  // возвращает кол-во узлов в двоичном дереве поиска, начиная с данного узла
        {
            int sum = 1;
            //node.Visit = true;
            if (node.Left != null && node.Right != null)
            {
                if (Convert.ToInt32(node.Left.Data) < Convert.ToInt32(node.Data) && Convert.ToInt32(node.Right.Data) >= Convert.ToInt32(node.Data))
                {
                    sum += BinarySearch(node.Left);
                    sum += BinarySearch(node.Right);
                }
            }
            return sum;
        }



        public int FindBinarySearch()  //возвращает id корня максимальнорго поддерева двоичного поиска
        {
            int data;
            int id = 1;
            int maxCount;
            data = Convert.ToInt32(top.Data);
            maxCount = BinarySearch(top);
            BinarySearch2(ref data, ref maxCount, ref id, ref top);
            return id;
        }

        public void DeSelect(NodeTree node)                   // снятие признака посещения
        {
            if (node != null)
            {
                node.Visit = false;
                DeSelect(node.Left);
                DeSelect(node.Right);
            }
        }

        public void Delta(NodeTree node, int dx, int dy)      // смещение поддерева
        {
            node.X -= dx; node.Y -= dy;
            if (node.Left != null)
                Delta(node.Left, dx, dy);
            if (node.Right != null)
                Delta(node.Right, dx, dy);
        }

        public void BinarySearch2(ref int data, ref int maxCount, ref int id, ref NodeTree node) //  после выполнения метода в data иmaxCunt будут записаны данные и максимальное число э-тов дерева бинарного поиска
        {
            int count;
            count = BinarySearch(node);
            if (count > maxCount)
            {
                data = Convert.ToInt32(node.Data);
                maxCount = count;
                id = node.Id;
            }
            if (node.Left != null) BinarySearch2(ref data, ref maxCount, ref id, ref node.Left);
            if (node.Right != null) BinarySearch2(ref data, ref maxCount, ref id, ref node.Right);
        }


        public NodeTree FindNode(NodeTree node, int x, int y)     // поиск по координатам 
        {
            NodeTree result = null;
            if (node == null)
                return result;

            if (((node.X - x) * (node.X - x) + (node.Y - y) * (node.Y - y)) < 100)
                result = node;
            else
            {
                result = FindNode(node.Left, x, y);
                if (result == null)
                    result = FindNode(node.Right, x, y);
            }
            return result;
        }


        public void RandomInsert(ref NodeTree node, ref int countId, int data, int x, int y)  // случайное заполнениие дерева
        {
            countId++;
            int dh = 1;
            int step = 50;
            if (node == null)
                node = new NodeTree(null, null, data, x, y, countId);
            else
            {

                int q = rnd.Next(0, 2);
                if (q == 0)
                {
                    RandomInsert(ref node.Left, ref countId, data, node.X - step, node.Y + dh * step);
                }
                if (q == 1)
                {
                    RandomInsert(ref node.Right, ref countId, data, node.X + step, node.Y + dh * step);
                }
            }
        }
    }
}