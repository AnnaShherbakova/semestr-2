using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Graf
    {
        public List<NodeGraf> Nodes { get; set; }
        private List<int> NumbersOfEntrance { get; set; }
        // public List<int> NumberOfExit { get; set; }
        public Path Path { get; set; }

        public Graf(int[,] matrix, int[] entrances, int[] exits)
        {
            Nodes = new List<NodeGraf>();
            NumbersOfEntrance = ArrayUtils.ArrToList(entrances);
            // NumberOfExit = ArrToList(exits);
            BuildGrafByMatrix(matrix, 2, ArrayUtils.ArrToList(exits));
            Path = new Path();
        }


        public Graf(int[,] matrix)
        {
            Nodes = new List<NodeGraf>();
            BuildGrafByMatrix(matrix, 1);
        }



        private void BuildGrafByMatrix(int[,] matrix, int param, List<int> NumberOfExit = null)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<int> edges = new List<int>();
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 1)
                        edges.Add(j);
                }
                AddNode(i, edges, param, NumberOfExit);
            }
        }

        private void AddNode(int number, List<int> edges, int param, List<int> NumberOfExit)
        {
            NodeGraf node;
            if (param == 1)  //добавление шестерёнки
                node = new NodeGraf(number);
            else    // добавление узла лабиринта
                node = new NodeGraf(number, InitStateOfNode(number, NumbersOfEntrance, NumberOfExit)); // добавление узла лабиринта
            foreach (int edge in edges)
            {
                Edge e = new Edge(edge);
                node.Edges.Add(e);
            }
            Nodes.Add(node);
        }
        //
        //

        public void EylerWays()
        {
            Stack<int> StackPath = new Stack<int>();
            FindWayEyler(StackPath, NumbersOfEntrance[0], 0, 0, 0);
        }

        private void FindWayEyler(Stack<int> StackPath, int i/*индекс текущего узла*/, int j/*индекс предыдущего узла*/, int numberOfMan, int I)
        {
            for (int k = 0; k < Nodes[i].Edges.Count; k++)  //
                if (Nodes[i].Edges[k].NumNode == j)         //  отмечаем только что пройденный ребро
                    Nodes[i].Edges[k].Visit = true;         // 

            StackPath.Push(Nodes[i].Number);
            if (Nodes[i].State == 2)// это выход
            {
                RememberPath(StackPath, numberOfMan);
                if (I == NumbersOfEntrance.Count - 1) return;

                FindWayEyler(StackPath, NumbersOfEntrance[I + 1], i, numberOfMan + 1, I + 1);
            }
            else
                foreach (Edge edge in Nodes[i].Edges)
                {
                    if (edge.Visit == false)
                    {
                        edge.Visit = true;
                        FindWayEyler(StackPath, edge.NumNode, i, numberOfMan, I);
                    }
                }

            for (int k = 0; k < Nodes[i].Edges.Count; k++)  //
                if (Nodes[i].Edges[k].NumNode == j)         //  отмечаем только что пройденный ребро
                    Nodes[i].Edges[k].Visit = false;

            StackPath.Pop();
            return;

        }

        public void GamiltonWays()
        {
            Stack<int> StackPath = new Stack<int>();
            FindWayGamilton(StackPath, NumbersOfEntrance[0], 0, 0);
        }

        private void FindWayGamilton(Stack<int> StackPath, int i, int numberOfMan, int I)
        {
            Nodes[i].Visit = true;
            StackPath.Push(Nodes[i].Number);
            if (Nodes[i].State == 2)// это выход
            {
                RememberPath(StackPath, numberOfMan);
                if (I == NumbersOfEntrance.Count - 1) return;
                if (Nodes[NumbersOfEntrance[I + 1]].Visit == false)
                {
                    FindWayGamilton(StackPath, NumbersOfEntrance[I + 1], numberOfMan + 1, I + 1);

                }
            }
            else
                foreach (Edge edge in Nodes[i].Edges)
                {
                    if (Nodes[edge.NumNode].Visit == false)
                        FindWayGamilton(StackPath, edge.NumNode, numberOfMan, I);
                }
            Nodes[i].Visit = false;
            StackPath.Pop();
            return;
        }

        private void RememberPath(Stack<int> path, int number)
        {
            if (number > Path.NumberOfMan)
            {
                Path.NumberOfMan = number;
                Path.Paths = path.ToList<int>();
            }
        }

        private int InitStateOfNode(int number, List<int> entrances, List<int> exits)
        {    // инициализирует узел лабиринта как вход выход или обычный узел
            if (entrances.Contains(number))
                return 1;
            else if (exits.Contains(number))
                return 2;
            else
                return 0;
        }

        //
        public int CalcNumberOfTurningGears()
        {
            int n = NumberOfTurnGears();
            if (n == 0)
            {
                DeleteByOneGear();
                n = NumberOfTurnGears();
            }
            return n;
        }

        private bool Turn(int index, int spin)
        {
            if (Nodes[index].Exist == false)
                return true;
            if (Nodes[index].Spin == 0 || Nodes[index].Spin == spin)
            {
                if (Nodes[index].Visit) return true;
                Nodes[index].Spin = spin;
                Nodes[index].Visit = true;
            }
            else
                return false;
            foreach (Edge edge in Nodes[index].Edges)
            {
                bool res = Turn(edge.NumNode, ChangeSpin(spin));
                if (res == false)
                    return false;
            }
            return true;
        }

        private int ChangeSpin(int spin)
        {
            if (spin == 1)
                return 2;
            else
                return 1;
        }

        private int NumberOfTurnGears()
        {
            int num = 0;
            if (Turn(0, 1) == false)
                StopAllGears();
            else
                foreach (NodeGraf gear in Nodes)
                    if (gear.Spin != 0)
                        num += 1;
            return num;
        }

        private void StopAllGears()
        {
            foreach (NodeGraf gear in Nodes)
            {
                gear.Spin = 0;
                gear.Visit = false;
            }
        }

        private void DeleteGear(int index)
        {
            Nodes[index].Exist = false;
        }

        private void ReviveAllGears()
        {
            foreach (NodeGraf gear in Nodes)
                gear.Exist = true;
        }

        private void SaveMaxNSpin(ref int MaxNumberSpiner, ref List<int> IndexesOfExistGears)
        {
            int n = NumberOfTurnGears();
            if (n > MaxNumberSpiner)
            {
                MaxNumberSpiner = n;
                IndexesOfExistGears = FillListIndexesOfExistGears();
            }
            ReviveAllGears();
            StopAllGears();
        }

        private void DeleteByOneGear()
        {// если первая шестерёнка не крутится
            List<int> IndexesOfExistGears = new List<int>();
            int MaxNumberSpiner = 0;
            for (int i = 1; i < Nodes.Count; i++)
            {
                DeleteGear(i);
                SaveMaxNSpin(ref MaxNumberSpiner, ref IndexesOfExistGears);
            }
            if (MaxNumberSpiner == 0)
                for (int i = 1; i < Nodes.Count; i++)
                {
                    for (int j = i; j < Nodes.Count; j++)
                    {
                        DeleteGear(i);
                        DeleteGear(j);
                        SaveMaxNSpin(ref MaxNumberSpiner, ref IndexesOfExistGears);
                    }
                }
            if (MaxNumberSpiner == 0)
                for (int i = 1; i < Nodes.Count; i++)
                {
                    for (int j = i; j < Nodes.Count; j++)
                    {
                        for (int k = j; k < Nodes.Count; j++)
                        {
                            DeleteGear(i);
                            DeleteGear(j);
                            DeleteGear(k);
                            SaveMaxNSpin(ref MaxNumberSpiner, ref IndexesOfExistGears);
                        }
                    }
                }

            for (int i = 1; i < Nodes.Count; i++)
            {

                if (IndexesOfExistGears.Contains(i))
                    Nodes[i].Exist = true;
                else
                    Nodes[i].Exist = false;
            }
        }

        private List<int> FillListIndexesOfExistGears()
        {
            List<int> list = new List<int>();
            for (int i = 1; i < Nodes.Count; i++)
            {
                if (Nodes[i].Exist)
                    list.Add(i);
            }
            return list;
        }



    }
}