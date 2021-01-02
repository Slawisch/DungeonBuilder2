using System;
using System.Drawing;

namespace DungeonBuilder2
{
    public static class MathExtension
    {
        public static double GetAngle(this Point point1, Point point2)
        {
            var deltaPoint = new Point(point2.X - point1.X, point2.Y - point1.Y);
            var angle = Math.Acos(deltaPoint.X / Math.Sqrt(deltaPoint.X * deltaPoint.X + deltaPoint.Y * deltaPoint.Y));
            if (deltaPoint.Y > 0)
                angle *= -1;
            return angle;
        }

        public static double GetDistance(this Point point1, params Point[] point2)
        {
            double distance = 0;
            Point lastPoint = point1;
            foreach (var point in point2)
            {
                distance += Math.Sqrt(Math.Pow(lastPoint.X - point.X, 2) + Math.Pow(lastPoint.Y - point.Y, 2));
                lastPoint = point;
            }
            return distance;
        }

        public static Point AvgPoint(this Point point1, Point point2)
        {
            return new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2);
        }
        
        public static bool IsInPolygon(this Point p, Point[] poly)
        {
            Point p1, p2;
            bool inside = false;

            if (poly.Length < 3)
            {
                return inside;
            }

            var oldPoint = new Point(
                poly[poly.Length - 1].X, poly[poly.Length - 1].Y);

            for (int i = 0; i < poly.Length; i++)
            {
                var newPoint = new Point(poly[i].X, poly[i].Y);

                if (newPoint.X > oldPoint.X)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.X < p.X) == (p.X <= oldPoint.X)
                    && (p.Y - (long) p1.Y)*(p2.X - p1.X)
                    < (p2.Y - (long) p1.Y)*(p.X - p1.X))
                {
                    inside = !inside;
                }

                oldPoint = newPoint;
            }

            return inside;
        }

        public static bool IsNearLineApices(this Point pt, Point[] points, int maxDistance)
        {
            foreach (var linePoint in points)
            {
                if (pt.GetDistance(linePoint) < maxDistance)
                {
                    return true;
                }
            }

            return false;
        }

    }
}