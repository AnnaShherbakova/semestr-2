using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLibrary
{
    public class Horse
    {
        public bool[,] Board { get; set; }
        public List<Cell> Protocol { get; set; }

        private int[,] d = { { 1, -2 }, { 1, 2 }, { -1, 2 }, { -1, -2 }, { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 } };

        public Horse(int s)
        {
            Board = new bool[s, s];
            Protocol = new List<Cell>();
        }

        public void Move(int X, int Y, int n, int t)
        {
            int iX = 0, iY = 0, nn = ++n;
            bool WasStep = false;
            Board[X, Y] = true;
            for (int i = 0; i < 8; i++)
            {
                iX = X + d[i, 0];
                iY = Y + d[i, 1];
                if (iX > -1 && iX < Board.GetLength(0) && iY > -1 && iY < Board.GetLength(0) && Board[iX, iY] == false)
                {
                    WasStep = true;
                    Cell cell = new Cell() { Count = nn, X = iX, Y = iY };
                    Protocol.Add(cell);
                    t++;
                    Move(iX, iY, n, t);
                }
            }
            if (!WasStep) n--;
        }

    }
}
