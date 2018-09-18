using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LogicLibrary
{
    public class NodeTree
    {
        public NodeTree Left;
        public NodeTree Right;
        public object Data { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Visit { get; set; }
        public int Count { get; set; }
        public int Id { get; set; }


        public NodeTree(NodeTree Left, NodeTree Right, object data, int x, int y, int id) // конструктор
        {
            this.Left = Left;
            this.Right = Right;
            this.Data = data;
            this.X = x;
            this.Y = y;
            this.Visit = false;
            this.Count = 1;
            this.Id = id;
        }
    }
}
