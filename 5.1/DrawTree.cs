using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LogicLibrary;

namespace _5._1
{
    public class DrawTree
    {
        public Graphics g { get; set; }

        public void Draw(NodeTree top)                             // рисование дерева
        {
            g.Clear(Color.White);
            if (top != null)
                DrawNode(top);
        }



        public void FindItemId(int id, NodeTree node)
        {
            if (node.Id == id)
            {
                ColorBinnaryTree(node);
                return;
            }
            else
            {
                if (node.Left != null) FindItemId(id, node.Left);
                if (node.Right != null) FindItemId(id, node.Right);
            }
        }
        public void ColorBinnaryTree(NodeTree node)  // возвращает кол-во узлов в двоичном дереве поиска, начиная с данного узла
        {
            node.Visit = true;
            if (node.Left != null && node.Right != null)
            {
                if (Convert.ToInt32(node.Left.Data) < Convert.ToInt32(node.Data) && Convert.ToInt32(node.Right.Data) >= Convert.ToInt32(node.Data))
                {
                    ColorBinnaryTree(node.Left);
                    ColorBinnaryTree(node.Right);
                }
            }
        }

        public void DrawNode(NodeTree node)                          // рисование дерева
        {
            Pen myPen = Pens.Black;
            SolidBrush myBrush = (SolidBrush)Brushes.White;
            Font myFont = new Font("Courier New", 10, FontStyle.Bold);

            int R = 17;
            if (node.Left != null)
                g.DrawLine(myPen, node.X, node.Y, node.Left.X, node.Left.Y);
            if (node.Right != null)
                g.DrawLine(myPen, node.X, node.Y, node.Right.X, node.Right.Y);

            if (node.Visit)
                myBrush = (SolidBrush)Brushes.Yellow;
            else
                myBrush = (SolidBrush)Brushes.LightYellow;

            g.FillEllipse(myBrush, node.X - R, node.Y - R, 2 * R, 2 * R);
            g.DrawEllipse(myPen, node.X - R, node.Y - R, 2 * R, 2 * R);
            string s = Convert.ToString(node.Data) + ":" + Convert.ToString(node.Count);
            SizeF size = g.MeasureString(s, myFont);
            g.DrawString(s, myFont, Brushes.Black,
                node.X - size.Width / 2,
                node.Y - size.Height / 2);

            if (node.Left != null)
                DrawNode(node.Left);
            if (node.Right != null)
                DrawNode(node.Right);
        }
    }
}