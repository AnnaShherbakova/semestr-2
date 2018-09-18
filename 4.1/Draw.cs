using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace _4._1
{
    public class Draw
    {
        public Graphics Bitmap { get; set; }
        public BallWithNumber[] Balls { get; set; }

        public Draw(Graphics bitmap, BallWithNumber[] balls)
        {
            Bitmap = bitmap;
            Balls = balls;
        }

        public void DrawBalls()
        {
            Bitmap.Clear(Color.White);
            for (int i = 0; i < Balls.Length; i++)
            {
                Pen pen0 = new Pen(Balls[i].Color, 2);
                Rectangle rectangle0 = new Rectangle(Balls[i].X, Balls[i].Y, Balls[0].Radius, Balls[i].Radius);
                Bitmap.DrawEllipse(pen0, rectangle0);
                Font myFont = new Font("Arial", 12, FontStyle.Bold);
                Brush myBrush = new SolidBrush(Color.Blue);
                Bitmap.DrawString(Convert.ToString(Balls[i].Numer), myFont, myBrush, Balls[i].X + 5, Balls[i].Y + 5);
            }
        }

        public void DrawSort()
        {
            for (int i = 0; i < Balls.Length; i++)
            {
                for (int j = i + 1; j < Balls.Length; j++)
                {
                    if (Balls[i].Numer > Balls[j].Numer)
                    {
                        Change(i, j);
                        BallWithNumber swap = Balls[i];
                        Balls[i] = Balls[j];
                        Balls[j] = swap;
                    }
                }
            }

        }

        public void Change(int n1, int n2)
        {
            Balls[n1].Color = Color.Red;
            Balls[n2].Color = Color.Red;

            for (int i = 0; i < 4; i++)
            {
                Balls[Math.Max(n1, n2)].Y -= (int)(Balls[Math.Max(n1, n2)].Radius / 2);
                Balls[Math.Min(n1, n2)].Y += (int)(Balls[Math.Min(n1, n2)].Radius / 2);
                DrawBalls();
                Thread.Sleep(100);
            }
            int d = Math.Abs((Balls[n2].X - Balls[n1].X)) / 10;
            for (int i = 0; i < 10; i++)
            {
                Balls[Math.Max(n1, n2)].X -= d;
                Balls[Math.Min(n1, n2)].X += d;
                DrawBalls();
                Thread.Sleep(50);
            }

            for (int i = 0; i < 4; ++i)
            {
                Balls[Math.Max(n1, n2)].Y += (int)(Balls[n2].Radius / 2);
                Balls[Math.Min(n1, n2)].Y -= (int)(Balls[n1].Radius / 2);
                DrawBalls();
                Thread.Sleep(80);
            }

            Thread.Sleep(200);

            Balls[n1].Color = Color.Black;
            Balls[n2].Color = Color.Black;
            DrawBalls();
        }
    }
}
