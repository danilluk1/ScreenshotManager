using ScreenManagerBL.Presenter;
using System.Drawing;

namespace ScreenManagerBL.View
{
    public interface IMainWindow : IView<MainFormPresenter>
    {
        Bitmap Screenshot { get; set; }

        void MakeInvisible();

        void MakeVisible();
    }
}