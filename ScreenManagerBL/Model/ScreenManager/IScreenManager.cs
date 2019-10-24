using ScreenManagerBL.Model.ScreenStrategy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenManagerBL.Core
{
    public interface IScreenManager
    {
        Bitmap Image { get; set; }
        Bitmap DoScr(IScreenStrategy strat, int w, int h, int x, int y);
        Modes Mode { get; set; }
    }
}
