using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenManagerBL.Model.ScreenStrategy;

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
        public ScreenManager()
        {
            
        }

        public Modes Mode { get; set; }
        public Bitmap Image { get; set; }

        public Bitmap DoScr(IScreenStrategy strat, int w, int h, int x, int y)
        {
            return strat.MakeScreen(w, h, x, y);
        }
    }
}
