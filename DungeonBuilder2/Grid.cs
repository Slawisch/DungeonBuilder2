using System;
using System.Drawing;

namespace DungeonBuilder2
{
    public class Grid
    {
        public readonly int Width;
        public readonly int Height;
        public bool IsRulerVisible = true;
        public bool IsGridVisible = false;
        public bool IsPointsVisible = true;
        private int _rulerWidth = 15;
        private int _scale = 10;
        private int _scaleMultiplier = 1;
        public int Scale
        {
            get => _scale;
            set
            {
                _scale = value;
                UpdateBitmap();
            }
        }

        public int ScaleMultiplier
        {
            get => _scaleMultiplier;
            set
            {
                _scaleMultiplier = value; 
                UpdateBitmap();
            }
        }

        public Bitmap BackBitmap;

        public Grid(int width, int height, int scale, int scaleMultiplier)
        {
            Width = width;
            Height = height;
            Scale = scale;
            ScaleMultiplier = scaleMultiplier;
        }

        public void UpdateBitmap()
        {
            BackBitmap = new Bitmap(Width, Height);
            var graphics = Graphics.FromImage(BackBitmap);
            
            if(IsPointsVisible)
                for (int i = 0; i < Math.Ceiling((decimal)Height/(Scale*ScaleMultiplier)); i++)
                {
                    for (int j = 0; j < Math.Ceiling((decimal)Width/(Scale*ScaleMultiplier)); j++)
                    {
                        BackBitmap.SetPixel(j*Scale*ScaleMultiplier, i*Scale*ScaleMultiplier, Color.Gray);
                    }
                }

            if (IsGridVisible)
            {
                for (int i = 0; i < Math.Ceiling((decimal) Width / (Scale * ScaleMultiplier)); i++)
                {
                    graphics.DrawLine(Pens.DimGray, i * Scale * ScaleMultiplier, 0, i * Scale * ScaleMultiplier,
                        Height);
                }

                for (int i = 0; i < Math.Ceiling((decimal) Height / (Scale * ScaleMultiplier)); i++)
                {
                    graphics.DrawLine(Pens.DimGray, 0, i * Scale * ScaleMultiplier, Width, i * Scale * ScaleMultiplier);
                }
            }

            if (IsRulerVisible)
            {
                for (int i = 0; i < Math.Ceiling((decimal) Height / 100); i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        graphics.DrawLine(Pens.Gainsboro, 0, i * 100 + j * 10, (int) (_rulerWidth * 0.3),
                            i * 100 + j * 10);
                    }

                    graphics.DrawLine(Pens.Gainsboro, 0, i * 100, _rulerWidth, i * 100);
                    if (i != 0)
                        graphics.DrawString(i + "m", new Font(FontFamily.GenericMonospace, 8, FontStyle.Regular),
                            Brushes.Gainsboro, (int) (_rulerWidth * 0.8), i * 100);
                }

                for (int i = 0; i < Math.Ceiling((decimal) Width / 100); i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        graphics.DrawLine(Pens.Gainsboro, i * 100 + j * 10, 0, i * 100 + j * 10,
                            (int) (_rulerWidth * 0.3));
                    }

                    graphics.DrawLine(Pens.Gainsboro, i * 100, 0, i * 100, _rulerWidth);
                    if (i != 0)
                        graphics.DrawString(i + "m", new Font(FontFamily.GenericMonospace, 8, FontStyle.Regular),
                            Brushes.Gainsboro, i * 100, (int) (_rulerWidth * 0.8));
                }
            }
        }

        public Point PtToGridPoint(Point pt)
        {
            var point = new Point();
            point.X = pt.X - pt.X % Scale;
            point.Y = pt.Y - pt.Y % Scale;
            
            if (pt.X % Scale >= Scale / 2)
                point.X += Scale;
            if (pt.Y % Scale >= Scale / 2)
                point.Y += Scale;

            return point;
        }
    }
}