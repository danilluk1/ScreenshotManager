using ScreenManagerBL.Model.ScreenStrategy;
using System.Drawing;

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
        public Modes Mode { get; set; }

        public Bitmap DoScr(IScreenStrategy strat, int w, int h, int x, int y)
        {
            return strat.MakeScreen(w, h, x, y);
        }
    }
}