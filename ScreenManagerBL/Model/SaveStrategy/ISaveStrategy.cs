using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenManagerBL.Model.SaveStrategy
{
    public interface ISaveStrategy
    {
        Bitmap Image { get; set; }
        ImageFormat SaveFormat { get; set; }
        string FileName { get; set; }
        void Save();
    }
}
