using System;
using System.Drawing;

namespace DungeonBuilder2
{
    [Serializable]
    public class Wall : BuildingComponent
    {
        public int Width { get; set; }
        private Point _end1 = Point.Empty;
        private Point _end2 = Point.Empty;
        public Point End1
        {
            get => _end1;
            set
            {
                _end1 = value;
                UpdatePosition();
            }
        }
        public Point End2
        {
            get => _end2;
            set
            {
                _end2 = value;
                UpdatePosition();
            }
        }

        public Wall()
        {
            
        }

        public Wall(Point point1, Point point2, int width)
        {
            Corners = new Point[4];
            Width = width;
            End1 = point1;
            End2 = point2;
        }

        protected override void UpdatePosition()
        {
            Corners[0] = End1;
            Corners[1] = End2;
            var angle = End1.GetAngle(End2) + Math.PI / 2;
            Point delta;
            angle = Double.IsNaN(angle) ? 0 : angle;
            delta = new Point((int)Math.Round(Math.Cos(angle) * Width), (int)Math.Round(-Math.Sin(angle) * Width));
            Corners[3] = new Point(End1.X - delta.X, End1.Y - delta.Y);
            Corners[2] = new Point(End2.X - delta.X, End2.Y - delta.Y);
        }

        public override void Move(int cx, int cy)
        {
            _end1.X += cx;
            _end1.Y += cy;
            _end2.X += cx;
            _end2.Y += cy;
            UpdatePosition();
        }
    }
}