using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DungeonBuilder2
{
    public class TestRectangle : GraphicalObject
    {
        public Rectangle RectBox;
        public bool Resizable = false;
   
        public TestRectangle(int x, int y, Size size)
        {
            CurContour = new Contour();
            CurContour.Apices = new List<ContourApex>();
            RectBox.X = x;
            RectBox.Y = y;
            RectBox.Size = size;
        }
        
        public override void DefineContour()
        {
            CurContour.Apices.Add(new ContourApex(0, RectBox.Location, new Size(8, 8), Cursors.Cross));
            
            CurContour.Apices.Add(new ContourApex(1, new Point(RectBox.Location.X + RectBox.Width, RectBox.Location.Y),
                new Size(8, 8), Cursors.Cross));
            
            CurContour.Apices.Add(new ContourApex(2,
                new Point(RectBox.Location.X + RectBox.Width, RectBox.Location.Y + RectBox.Height), new Size(8, 8),
                Cursors.Cross));
            
            CurContour.Apices.Add(new ContourApex(3, new Point(RectBox.Location.X, RectBox.Location.Y + RectBox.Height),
                new Size(8, 8), Cursors.Cross));
        }

        public override bool TryApexSetActive(MouseEventArgs mouseEventArgs)
        {
            foreach (var apex in CurContour.Apices)
            {
                if (new Rectangle(apex.PtLT, apex.Size).Contains(mouseEventArgs.Location))
                {
                    apex.Active = true;
                    CurContour.ActiveApexNum = apex.nVal;
                    return true;
                }
            }
            return false;
        }

        public override bool TryApexResetActive()
        {
            if (CurContour.ActiveApexNum != -1)
            {
                CurContour.Apices[CurContour.ActiveApexNum].Active = false;
                CurContour.ActiveApexNum = -1;
                return true;
            }
            return false;
        }

        public bool UpdateResizable(MouseEventArgs mouseEventArgs)
        {
            if ((RectBox.Contains(mouseEventArgs.Location) || CurContour.ActiveApexNum != -1) && !Resizable)
            {
                Resizable = true;
                return true;
            }

            if (!RectBox.Contains(mouseEventArgs.Location) && CurContour.ActiveApexNum == -1 && Resizable)
            {
                Resizable = false;
                return true;
            }
            return false;
        }
        
        public override bool MoveContourPoint(int i, int cx, int cy, Point ptMouse, MouseButtons catcher)
        {
            if (CurContour.ActiveApexNum == -1)
                return false;
            
            CurContour.Apices[i].PtReal.X += cx;
            CurContour.Apices[i].PtReal.Y += cy;
            
            if (i != 0)
                CurContour.Apices[0].PtReal = new Point(CurContour.Apices[3].PtReal.X, CurContour.Apices[1].PtReal.Y);
            if (i != 3)
                CurContour.Apices[3].PtReal = new Point(CurContour.Apices[0].PtReal.X, CurContour.Apices[2].PtReal.Y);
            if (i != 1)
                CurContour.Apices[1].PtReal = new Point(CurContour.Apices[2].PtReal.X, CurContour.Apices[0].PtReal.Y);
            if (i != 2)
                CurContour.Apices[2].PtReal = new Point(CurContour.Apices[1].PtReal.X, CurContour.Apices[3].PtReal.Y);

            RectBox.Location = CurContour.Apices[0].PtReal;
            RectBox.Width = CurContour.Apices[2].PtReal.X - CurContour.Apices[0].PtReal.X;
            RectBox.Height = CurContour.Apices[2].PtReal.Y - CurContour.Apices[0].PtReal.Y;
            
            foreach (var apex in CurContour.Apices)
            {
                apex.UpdatePtLT();
            }
            
            return true;
        }

        public override void Move(int cx, int cy)
        {
            RectBox.X += cx;
            RectBox.Y += cy;
        }
    }
}