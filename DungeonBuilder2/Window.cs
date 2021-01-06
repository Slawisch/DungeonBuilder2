using System;
using System.Drawing;

namespace DungeonBuilder2
{
    [Serializable]
    public class Window : Wall
    {
        public Window(Point point1, Point point2, int width):base(point1, point2, width) {}
        public Window():base(){}
    }
}