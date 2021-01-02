using System.Drawing;
using System.Windows.Forms;

namespace DungeonBuilder2
{
    public class ContourApex
    {
        public int nVal { get; set; }
        public bool Active { get; set; }
        public Point PtLT;
        public Point PtReal;
        public Size Size { get; private set; }
        private Cursor cursorShape;

        public ContourApex(int nVal, Point pt, Size size, Cursor cursorShape)
        {
            this.nVal = nVal;
            PtReal = pt;
            Size = size;
            this.cursorShape = cursorShape;
            PtLT = new Point(
                PtReal.X - Size.Width / 2,
                PtReal.Y - Size.Height / 2);
        }

        public void UpdatePtLT()
        {
            PtLT = new Point(
                PtReal.X - Size.Width / 2,
                PtReal.Y - Size.Height / 2);
        }
    }
}