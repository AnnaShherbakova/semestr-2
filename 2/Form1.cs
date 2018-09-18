using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using LogicLibrary;
using System.IO;

//30. Покрыть все клетки шахматной доски ходом коня,
//начальное положение коня на поле с координатами x0, y0
namespace _2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int CELL_SIZE = 50;
            chessboard.RowTemplate.Height = CELL_SIZE;
            DataGridViewUtils.InitGridForArr(chessboard, CELL_SIZE,
                true, false, false, false, false);
            int sizeFieldCount = 8;
            chessboard.ColumnCount = sizeFieldCount;
            chessboard.RowCount = sizeFieldCount;
            chessboard.Width = sizeFieldCount * CELL_SIZE + 3;
            chessboard.Height = sizeFieldCount * CELL_SIZE + 3;
            chessboard.ClearSelection();
            chessboard.MultiSelect = false;
            PaintBoard(chessboard);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int r = chessboard.SelectedCells[0].RowIndex;
            int c = chessboard.SelectedCells[0].ColumnIndex;
            //StreamWriter w = new StreamWriter("protocol.txt");
            Horse h = new Horse(8);
            h.Move(r, c, 0, 0);
            //w.Close();
            PaintWays(h.Protocol);
        }

        public void PaintWays(List<Cell> protocol)
        {
            drawCell(protocol[0]);
            for (int i = 1; i < protocol.Count; i++)
            {
                if (protocol[i].Count < protocol[i - 1].Count + 1)
                    Otkat(i - 1, protocol[i].Count - 1, protocol);
                drawCell(protocol[i]);
            }

        }

        public void Otkat(int startIndex, int endValue, List<Cell> protocol)
        {
            if (protocol[startIndex].Count != endValue)
            {
                int ind = startIndex;
                while (protocol[startIndex - 1].Count != protocol[ind].Count - 1)
                {
                    if (protocol[startIndex - 1].Count < protocol[ind].Count - 1)
                        drawCell(protocol[startIndex - 1]);
                    startIndex--;
                }
                drawCell(protocol[startIndex - 1]);
                Otkat(startIndex - 1, endValue, protocol);
            }
            else
                drawCell(protocol[startIndex]);
        }

        public void drawCell(Cell cell)
        {
            chessboard[cell.Y, cell.X].Style.BackColor = Color.Cyan;
            Update();
            Thread.Sleep(20);
            chessboard[cell.Y, cell.X].Style.BackColor = Color.Brown;
            Thread.Sleep(50);
            Update();
        }
        public void PaintBoard(DataGridView dgv)
        {
            for (int r = 0; r < dgv.ColumnCount; r++)
            {
                for (int c = 0; c < dgv.RowCount; c++)
                {
                    if ((r + c) % 2 == 0)
                        dgv[r, c].Style.BackColor = Color.Black;
                    else
                        dgv[r, c].Style.BackColor = Color.White;
                }
            }
        }

        private void chessboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chessboard_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
