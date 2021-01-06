using System.Drawing;

namespace DungeonBuilder2
{
    public class Line : BuildingComponent
    {
        public Point PointFrom;
        public Point PointTo;
        
        public Line(){}

        public Line(Point ptFrom, Point ptTo)
        {
            PointFrom = ptFrom;
            PointTo = ptTo;
        }
        
        public override void Move(int cx, int cy)
        {
        }

        protected override void UpdatePosition()
        {
        }
    }
}