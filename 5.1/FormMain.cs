using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicLibrary;

//В заданном дереве найти поддерево двоичного поиска с максимальным количеством элементов.
namespace _5._1
{
    public partial class FormMain : Form
    {
        bool drawing = false;
        Bitmap map;
        MyTree myTree;
        DrawTree tree = new DrawTree();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int countId = 0;
            int L = textBox1.Lines.Count();
            for (int i = 0; i < L; i++)
            {
                if (textBox1.Lines[i] != "")
                {
                    int k = Convert.ToInt32(textBox1.Lines[i]);
                    myTree.RandomInsert(ref myTree.top, ref countId, k, 200, 40);
                }
            }
            MyDraw();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            map = new Bitmap(pBox.Width, pBox.Height);
            tree.g = Graphics.FromImage(map);
            myTree = new MyTree();
        }

        public void MyDraw()
        {
            tree.Draw(myTree.top);
            pBox.Image = map;
        }
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            MyDraw();
        }


        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 128; i++)
            {
                int k = rnd.Next(20);
                textBox1.Text += Convert.ToString(k) + Convert.ToChar(13) + Convert.ToChar(10);
            }
        }

        private void buttonFindBinarySearch_Click(object sender, EventArgs e)
        {
            int id = myTree.FindBinarySearch();
            tree.FindItemId(id, myTree.top);
            MyDraw();
            pBox.Image = map;
        }


        private void pBox_MouseDown(object sender, MouseEventArgs e)
        {
            myTree.DeSelect(myTree.top);
            myTree.selectNode = myTree.FindNode(myTree.top, e.X, e.Y);
            drawing = myTree.selectNode != null;
            if (drawing)
                myTree.selectNode.Visit = true;
        }

        private void pBox_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
                myTree.Delta(myTree.selectNode, myTree.selectNode.X - e.X, myTree.selectNode.Y - e.Y);
            else
            {
                myTree.DeSelect(myTree.top);
                myTree.selectNode = myTree.FindNode(myTree.top, e.X, e.Y);
                if (myTree.selectNode != null)
                    myTree.selectNode.Visit = true;
            }
            MyDraw();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }
    }
}
