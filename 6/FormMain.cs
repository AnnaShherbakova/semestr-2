using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;

namespace _6
{
    public partial class FormMain : Form
    {

        Graphics Map { get; set; }
        Bitmap Bitmap { get; set; }
        Graf Labirint { get; set; }
        Draw DrawingGraf { get; set; }
        GraphicsContainer graphicsContainer;
        bool Drawing { get; set; }
        List<NodeGraf> Node;
        Path Path;


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(dgvMatrix, 30, false, true, true, true, true);
            Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Map = Graphics.FromImage(Bitmap);
            Drawing = false;
        }

        private void buttonGamilton_Click(object sender, EventArgs e)
        {
            //Labirint = new Graf(DataGridViewUtils.GridToArray2<int>(dgvMatrix), ArrayUtils.StrToInt(textBoxEntrance.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)), ArrayUtils.StrToInt(textBoxExit.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
            //DrawingGraf = new Draw(Map, Labirint);
            Path = Labirint.Path;
            Node = Labirint.Nodes;
            Map.EndContainer(graphicsContainer);
            Labirint.GamiltonWays();
            DrawingGraf = new Draw(Map, Labirint);
            DrawingGraf.DrawGraf();
            pictureBox.Image = Bitmap;
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            Drawing = true;
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            Drawing = false;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drawing)
            {
                for (int i = 0; i < Labirint.Nodes.Count; i++)
                    if (Labirint.Nodes[i].X - 25 < e.X && Labirint.Nodes[i].X + 25 > e.X && Labirint.Nodes[i].Y - 25 < e.Y && Labirint.Nodes[i].Y + 25 > e.Y)
                    {
                        Labirint.Nodes[i].X = e.X;
                        Labirint.Nodes[i].Y = e.Y;

                        break;
                    }

                DrawingGraf.DrawGraf();
                pictureBox.Image = Bitmap;
            }
        }


        private void buttonExample1_Click(object sender, EventArgs e)
        {
            int[,] ex1 = { { 0, 1, 0, 0, 0 }, { 1, 0, 1, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, 0 } };
            DataGridViewUtils.Array2ToGrid<int>(dgvMatrix, ex1);
            textBoxEntrance.Text = "1 4";
            textBoxExit.Text = "3 5";
        }

        private void buttonExample2_Click(object sender, EventArgs e)
        {
            int[,] ex1 = { { 0, 1, 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0, 1, 1, 1, 0 }, { 0, 0, 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0, 0, 0 }, { 0, 0, 1, 1, 0, 1, 0, 0, 1 }, { 0, 1, 0, 0, 1, 0, 0, 0, 1 }, { 0, 1, 0, 0, 0, 0, 0, 1, 0 }, { 0, 1, 0, 0, 0, 0, 1, 0, 1 }, { 0, 0, 0, 0, 1, 1, 0, 1, 0 } };
            DataGridViewUtils.Array2ToGrid<int>(dgvMatrix, ex1);
            textBoxEntrance.Text = "1 4 3";
            textBoxExit.Text = "7 8";
        }

        private void buttonExample3_Click(object sender, EventArgs e)
        {
            int[,] ex1 = { { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, { 0, 1, 1, 0, 0, 0, 1, 1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 1, 0, 0, 0, 1, 1 }, { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 } };
            DataGridViewUtils.Array2ToGrid<int>(dgvMatrix, ex1);
            textBoxEntrance.Text = "1 8 9";
            textBoxExit.Text = "6 10 4";
        }

        private void buttonEyler_Click(object sender, EventArgs e)
        {
            //Labirint = new Graf(DataGridViewUtils.GridToArray2<int>(dgvMatrix), ArrayUtils.StrToInt(textBoxEntrance.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)), ArrayUtils.StrToInt(textBoxExit.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
            //DrawingGraf = new Draw(Map, Labirint);
            Labirint.Path = Path;
            Labirint.Nodes = Node;
            Labirint.EylerWays();
            Map.EndContainer(graphicsContainer);
            DrawingGraf = new Draw(Map, Labirint);
            DrawingGraf.DrawGraf();
            pictureBox.Image = Bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Labirint = new Graf(DataGridViewUtils.GridToArray2<int>(dgvMatrix), ArrayUtils.StrToInt(textBoxEntrance.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)), ArrayUtils.StrToInt(textBoxExit.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
            DrawingGraf = new Draw(Map, Labirint);
            DrawingGraf.DrawGraf();
            Node = Labirint.Nodes;
            Path = Labirint.Path;
            graphicsContainer = Map.BeginContainer();
            pictureBox.Image = Bitmap;
        }


    }
}