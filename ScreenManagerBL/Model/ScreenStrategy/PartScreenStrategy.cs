using System.Drawing;
using System.Drawing.Imaging;

namespace ScreenManagerBL.Model.ScreenStrategy
{
    public class PartScreenStrategy : IScreenStrategy
    {
        public Bitmap MakeScreen(int width, int height, int x, int y)
        {
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(x, y, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            return bmp;
        }
    }
}