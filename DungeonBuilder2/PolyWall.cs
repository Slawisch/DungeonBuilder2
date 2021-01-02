using System.Drawing;

namespace DungeonBuilder2
{
    public class PolyWall : BuildingComponent
    {
        public PolyWall(Point[] corners)
        {
            Corners = corners;
        }
        
        protected override void UpdatePosition()
        {
            throw new System.NotImplementedException();
        }
        
        public override void Move(int cx, int cy)
        {
            Point[] newCorners = new Point[Corners.Length];
            for (int i = 0; i < newCorners.Length; i++)
            {
                newCorners[i] = new Point(Corners[i].X + cx, Corners[i].Y + cy);
            }
            Corners = newCorners;
        }
    }
}