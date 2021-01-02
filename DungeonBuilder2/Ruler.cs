using System;
using System.Drawing;

namespace DungeonBuilder2
{
    public class Ruler
    {
        private Point _end;
        public Point Start { get; set; }

        public Point End
        {
            get => _end;
            set { _end = value; UpdateLength(); }
        }

        public int Length { get; set; }

        public Ruler (Point p1, Point p2)
        {
            Start = p1;
            End = p2;
        }

        private void UpdateLength()
        {
            Length = (int)Start.GetDistance(End)*10;
        }
        
    }
}