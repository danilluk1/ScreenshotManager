using ScreenManagerBL.Model.ScreenStrategy;
using System.Drawing;

namespace ScreenManagerBL.Core
{
    public interface IScreenManager
    {
        Bitmap DoScr(IScreenStrategy strat, int w, int h, int x, int y);

        Modes Mode { get; set; }
    }
}