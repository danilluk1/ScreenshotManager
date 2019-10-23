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
        Bitmap MakeScreen(Screen scr);
        Bitmap MakeScreen(PictureBox panel);
        Bitmap MakeScreen();
        Modes Mode { get; set; }
    }
}
