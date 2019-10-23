using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenManagerBL.Model.ScreenStrategy
{
    public class FullScreenStrategy : IScreenStrategy
    {
        public Bitmap MakeScreen(int width, int height, int x, int y)
        {
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(0, 0, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            return bmp;
        }
    }
}
