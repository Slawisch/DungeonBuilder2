using System;
using System.Drawing;

namespace DungeonBuilder2
{
    public class Door : BuildingComponent
    {
        public bool Opened { get; set; } = true;
        public int Width { get; set; }
        public int OpenSide { private set; get; }
        public Door(Point fromPt, Point toPt, int openSide)
        {
            Corners = new Point[3];
            Corners[0] = fromPt;
            Corners[1] = toPt;
            OpenSide = openSide;
            Width = (int)Corners[0].GetDistance(Corners[1]);
            UpdatePosition();
        }

        protected sealed override void UpdatePosition()
        {
            var angle = Corners[0].GetAngle(Corners[1]) + Math.PI / 4;
            if (OpenSide == 1)
                angle += Math.PI * 1.5;
            Point delta;
            delta = new Point((int) Math.Round(Math.Cos(angle) * Width),
                    (int) Math.Round(-Math.Sin(angle) * Width));
            
            Corners[2] = new Point(Corners[0].X + delta.X, Corners[0].Y + delta.Y);
        }

        public override void Move(int cx, int cy)
        {
            Corners[0].X += cx;
            Corners[0].Y += cy;
            Corners[1].X += cx;
            Corners[1].Y += cy;
            UpdatePosition();
        }
    }
}