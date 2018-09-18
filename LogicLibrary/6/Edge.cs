using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Edge
    {
        public int NumNode { get; set; }      // № узла
        public bool Visit { get; set; }

        public Edge(int num)
        {
            NumNode = num;
            Visit = false;
        }
    }
}