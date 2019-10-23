using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenManagerBL.Model.ScreenStrategy
{
    public interface IScreenStrategy
    {
        Bitmap MakeScreen(int width, int height, int x, int y);
    }
}
