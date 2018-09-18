using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LogicLibrary;

namespace _6
{
    public class Draw
    {
        public Graphics Map { get; set; }
        public Graf Graf { get; set; }

        Pen Pen { get; set; }
        Brush Brush { get; set; }
        Font Font { get; set; }
        const int Radius = 25;
        Color[] colorsNodes = { Color.DarkRed, Color.Blue, Color.Green };
        Color[] colorsWays = { Color.Red, Color.BlueViolet, Color.Cyan, Color.Gold, Color.HotPink, Color.BurlyWood, Color.Lime };



        public Draw(Graphics g, Graf graf)
        {
            Map = g;
            Graf = graf;
        }

        public void DrawGraf()
        {
            Map.Clear(Color.AliceBlue);
            foreach (NodeGraf gear in Graf.Nodes)
            {
                DrawGear(gear);
            }
        }

        public void EndContainer(System.Drawing.Drawing2D.GraphicsContainer container)
        {

        }
        private void DrawGear(NodeGraf gear)
        {
            Rectangle rectangle = new Rectangle(gear.X - Radius, gear.Y - Radius, Radius * 2, Radius * 2);
            Pen = new Pen(colorsNodes[gear.State]);
            Brush = new SolidBrush(colorsNodes[gear.State]);
            Map.DrawEllipse(Pen, rectangle);
            Map.FillEllipse(Brush, rectangle);
            Brush = new SolidBrush(Color.White);
            Font = new Font("Courier New", 10, FontStyle.Bold);
            Map.DrawString(Convert.ToString(gear.Number + 1), Font, Brush, gear.X, gear.Y);
            Pen = new Pen(Color.Black);
            for (int i = 0; i < gear.Edges.Count; i++)
            {
                Map.DrawLine(Pen, gear.X, gear.Y, Graf.Nodes[gear.Edges[i].NumNode].X, Graf.Nodes[gear.Edges[i].NumNode].Y);
            }
            DrawPaths();
        }

        private void DrawPaths()
        {
            int j = 0;
            Pen = new Pen(colorsWays[j++], 2);
            for (int i = 0; i < Graf.Path.Paths.Count - 1; i++)
            {
                if (Graf.Nodes[Graf.Path.Paths[i + 1]].State == 2)
                {
                    Pen = new Pen(colorsWays[j++], 3);
                    continue;
                }
                Map.DrawLine(Pen, Graf.Nodes[Graf.Path.Paths[i]].X, Graf.Nodes[Graf.Path.Paths[i]].Y, Graf.Nodes[Graf.Path.Paths[i + 1]].X, Graf.Nodes[Graf.Path.Paths[i + 1]].Y);
            }
        }

        private void ClearPaths()
        {
            Pen = new Pen(Color.Black, 1);
            for (int i = 0; i < Graf.Path.Paths.Count - 1; i++)
            {

                Map.DrawLine(Pen, Graf.Nodes[Graf.Path.Paths[i]].X, Graf.Nodes[Graf.Path.Paths[i]].Y, Graf.Nodes[Graf.Path.Paths[i + 1]].X, Graf.Nodes[Graf.Path.Paths[i + 1]].Y);
            }

        }

    }
}