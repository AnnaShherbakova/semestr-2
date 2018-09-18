using LogicLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _4._1
{
    public partial class Form1 : Form
    {
        private BallWithNumber[] Balls;
        private Random rnd = new Random();

        public static double xMin = -1000, yMin = -1, xMax = 26000, yMax = 13;
        public static Pen MyPen1 = new Pen(Brushes.Black, 1);
        public static Pen MyPen2 = new Pen(Brushes.Silver, 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawBallsButton_Click(object sender, EventArgs e)
        {
            const int maxNumber = 10;
            const int topBalls = 100;
            const int otstupOtKraya = 20;
            const int ballsRadius = 30;

            int n = Convert.ToInt32(numberElementTextBox.Text);
            if (n <= maxNumber && n >= 1)
            {
                Balls = new BallWithNumber[n];
                for (int i = 0; i < n; i++)
                {
                    Balls[i] = new BallWithNumber();
                    Balls[i].Y = topBalls;
                    Balls[i].X = otstupOtKraya + i * (2 * ballsRadius);
                    Balls[i].Color = Color.Black;
                    Balls[i].Radius = ballsRadius;
                }
                FillRandom();
            }
            MyDraw();

        }
        void FillRandom()
        {
            foreach (BallWithNumber ball in Balls)
            {
                ball.Numer = rnd.Next(1, 100);
            }
        }

        private void fillRandonbutton_Click(object sender, EventArgs e)
        {
            FillRandom();
            MyDraw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1200;
            Height = 600;
            Rectangle rectangle = new Rectangle(3, 3, 40, 50);

        }


        public void MyDraw()
        {
            Graphics map = panel1.CreateGraphics();
            Draw ob = new Draw(map, Balls);
            ob.DrawBalls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics map = panel1.CreateGraphics();
            Draw ob = new Draw(map, Balls);
            //ob.DrawBalls();
            ob.DrawSort();
        }

        private void ShowGraficButton_Click(object sender, EventArgs e)
        {
            Sort obj = new Sort();
            int[] kolvoEltov = new int[] { 10, 100, 300, 500 };
            int[] countEx;
            int[] countCom;
            obj.GetCountCompareExchange(kolvoEltov, out countEx, out countCom);
            chart1.ChartAreas[0].AxisX.Minimum = 10;
            chart1.Series[0].Points.DataBindXY(kolvoEltov, countCom);
            chart1.Series[1].Points.DataBindXY(kolvoEltov, countEx);
        }




    }
}

