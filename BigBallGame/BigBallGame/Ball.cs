using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BigBallGame
{
    public enum BallType
    {
        Monster,
        Regular,
        Repelent
    }
    public class Ball
    {
        public PointF MapLocation;
        public Color FillColor, DrawColor;
        public int Radius;
        public float dx, dy;
        public BallType type;
        public bool destroyed;
        public Ball()
        {
            MapLocation = new PointF(Engine.rnd.Next(40, Engine.resx - 40), Engine.rnd.Next(40, Engine.resy - 40));
            FillColor = Color.FromArgb(Engine.rnd.Next(256), Engine.rnd.Next(256), Engine.rnd.Next(256));
            DrawColor = Color.Black;
            Radius = Engine.rnd.Next(20, 50);

            do
            {
                dx = Engine.rnd.Next(-3, 4);
                dy = Engine.rnd.Next(-3, 4);
            }
            while (dx == 0 || dy == 0);
            destroyed = false;
        }
        public virtual void Draw()
        {
            Engine.grp.FillEllipse(new SolidBrush(FillColor), MapLocation.X - Radius / 2, MapLocation.Y - Radius / 2, Radius * 2, Radius * 2);
            Engine.grp.DrawEllipse(new Pen(DrawColor), MapLocation.X - Radius / 2, MapLocation.Y - Radius / 2, Radius * 2, Radius * 2);
        }

        public void Turn()
        {
            MapLocation.X += dx;
            MapLocation.Y += dy;

            if ((MapLocation.X - Radius / 2) < 0)
                dx = -1 * dx;
            if ((MapLocation.Y - Radius / 2) < 0)
                dy = -1 * dy;
            if ((MapLocation.X + Radius / 2 + dx) > Engine.resx)
                dx = -1 * dx;
            if ((MapLocation.Y + Radius / 2 + dy) > Engine.resy)
                dy = -1 * dy;
        }
    }

    public class Monster : Ball
    {
        public Monster() : base()
        {
            dx = 0;
            dy = 0;
            FillColor = Color.Gray;
            DrawColor = Color.Black;
            type = BallType.Monster;
        }
        public override void Draw()
        {
            base.Draw();
            Engine.grp.DrawEllipse(new Pen(DrawColor, 5), MapLocation.X - Radius / 2, MapLocation.Y - Radius / 2, Radius * 2, Radius * 2);
        }
    }

    public class Regular : Ball
    {
        public Regular() : base()
        {
            Radius = Engine.rnd.Next(5, 10);
            type = BallType.Regular;
        }
    }

    public class Repelent : Ball
    {
        public Repelent() : base()
        {
            type = BallType.Repelent;
        }
    }
}

