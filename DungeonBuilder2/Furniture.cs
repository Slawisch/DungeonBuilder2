using System;
using System.Drawing;

namespace DungeonBuilder2
{
    public class Furniture
    {
        public Image FImage { get; set; }
        public Point Location { get; set; }
        public Furniture(Image img, Point ptLocation)
        {
            FImage = img;
            Location = ptLocation;
        }
        
    }
}