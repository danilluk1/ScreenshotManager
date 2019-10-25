using System.Drawing;

namespace ScreenManagerBL.Model.ScreenStrategy
{
    public interface IScreenStrategy
    {
        Bitmap MakeScreen(int width, int height, int x, int y);
    }
}