using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DungeonBuilder2
{
    public abstract class GraphicalObject
    {
        public Contour CurContour;
        public abstract void DefineContour ();
        public abstract bool TryApexSetActive(MouseEventArgs mouseEventArgs);
        public abstract bool TryApexResetActive();
        public abstract void Move (int cx, int cy);
        public abstract bool MoveContourPoint (int i, 
            int cx, int cy, Point ptMouse, 
            MouseButtons catcher);
    }
}