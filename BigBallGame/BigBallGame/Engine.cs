using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BigBallGame
{
    public static class Engine
    {
        public static Random rnd = new Random();
        public static Graphics grp;
        public static Bitmap bmp;
        public static PictureBox display;
        public static int resx, resy;
        public static Color backColor = Color.Green;
        public static int countR = 20;

        public static void initGraph(PictureBox Display)
        {
            display = Display;
            resx = display.Width;
            resy = display.Height;
            bmp = new Bitmap(resx, resy);
            grp = Graphics.FromImage(bmp);
            clearGraph();
            refreshGraph();
        }
        public static void refreshGraph()
        {
            display.Image = bmp;
        }
        public static void clearGraph()
        {
            grp.Clear(backColor);
        }


        public static List<Ball> balls = new List<Ball>();
        public static void DrawMap()
        {
            clearGraph();
            foreach (Ball bbg in balls)
                bbg.Draw();
            refreshGraph();
        }


        public static void TurnMap()
        {
            foreach (Ball bbg in balls)
                bbg.Turn();

            for (int i = 0; i < balls.Count - 1; i++)
                for (int j = i + 1; j < balls.Count; j++)
                    if (Distance(balls[i].MapLocation, balls[j].MapLocation) < (balls[i].Radius + balls[j].Radius))
                    {
                        if (!balls[i].destroyed && (!balls[j].destroyed))
                            Collide(balls[i], balls[j]);
                    }

            balls = balls.FindAll(delegate (Ball a) { return !a.destroyed; });
        }

        public static float Distance(PointF A, PointF B)
        {
            return (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        public static void Collide(Ball A, Ball B)
        {
            if (A.type == BallType.Regular && B.type == BallType.Regular)
            {
                Color CombinedColor = Combine(A.Radius, A.FillColor, B.Radius, B.FillColor);
                if (A.Radius > B.Radius)
                {
                    A.Radius += B.Radius;
                    A.FillColor =CombinedColor;
                    B.destroyed = true;
                    countR--;
                }
                else
                {
                    B.Radius += A.Radius;
                    B.FillColor = CombinedColor;
                    A.destroyed = true;
                    countR--;
                }
            }
            else
                if (A.type == BallType.Regular && B.type == BallType.Monster)
            {
                A.destroyed = true;
                B.Radius += A.Radius;
                countR--;
            }
            else
                    if (A.type == BallType.Monster && B.type == BallType.Regular)
            {
                B.destroyed = true;
                A.Radius += B.Radius;
                countR--;
            }

              else
                if(A.type==BallType.Regular && B.type==BallType.Repelent)
            {
                B.FillColor = A.FillColor;
                A.dx *= -1;
                A.dy *= -1;
            }
        }

        public static Color Combine(int s1, Color A, int s2, Color B)
        {
            int r = (s1 * A.R + s2 * B.R) / (s1 + s2);
            int g = (s1 * A.G + s2 * B.G) / (s1 + s2);
            int b = (s1 * A.B + s2 * B.B) / (s1 + s2);

            return Color.FromArgb(r, g, b);
        }

    }
}

