using System.Drawing;

namespace ScreenManagerBL.Model.SaveStrategy
{
    public interface ISaveStrategy
    {
        Bitmap Image { get; set; }

        void Save();
    }
}