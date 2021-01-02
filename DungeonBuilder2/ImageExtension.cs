using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace DungeonBuilder2
{
    public static class ImageExtension
    {
        public static Image ResizeImage(this Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }
        
        public static Image ResizeImage(this Image imgToResize, int width, int height)
        {
            return new Bitmap(imgToResize, width, height);
        }
        
        public static Image ResizeImage(this Image imgToResize, float multiplier)
        {
            return new Bitmap(imgToResize, (int)(imgToResize.Width * multiplier), (int)(imgToResize.Height * multiplier));
        }
    }
}