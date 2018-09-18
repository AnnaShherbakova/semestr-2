using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class NodeGraf
    {
        public int Number { get; set; }  // нумерация с 0
        public List<Edge> Edges { get; set; } //   ребра
        public bool Visit { get; set; }
        public int X { get; set; }
        public int Y { get; set; }     //
        public int Spin { get; set; }  // 1 - по часовой  2 - против часовой  0 - не вращается
        public bool Exist { get; set; }
        public int Polozhenie { get; set; } // положение шестерёнки(зубьев)
        public int State { get; set; }  // 0 - обычный узел, 1 - вход , 2 - выход  лабиринта


        public NodeGraf(int number)  // создание шестерёнки
        {
            Number = number;
            Polozhenie = 1;
            Spin = 0;
            Exist = true;
            Visit = false;
            Edges = new List<LogicLibrary.Edge>();
        }

        public NodeGraf(int number, int state)  // создание узла лабиринта
        {
            Number = number;
            Visit = false;
            X = 20 + 50 * number;
            Y = 20 + 30 * number;
            Edges = new List<LogicLibrary.Edge>();
            State = state;
        }
    }

}
