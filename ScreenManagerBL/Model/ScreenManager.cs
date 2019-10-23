using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenManagerBL.Core
{
    public enum Modes
    {
        FullScreen,
        PartScreen,
        Window
    }
    public class ScreenManager : IScreenManager
    {
        public ScreenManager(Modes mode)
        {
            Mode = mode;
        }

        public Modes Mode { get; set; }

        public Bitmap MakeScreen(Screen scr)
        {
            Bitmap bmp = new Bitmap(scr.Bounds.Width, scr.Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(0, 0, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            return bmp;
        }

        public Bitmap MakeScreen(PictureBox box)
        {
            Bitmap bmp = new Bitmap(box.Width, box.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(box.Left, box.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            return bmp;
        }

        public Bitmap MakeScreen()
        {
            throw new NotImplementedException();
        }
    }
}
