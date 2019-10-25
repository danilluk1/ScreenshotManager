using ScreenManagerBL.Presenter;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenManagerBL.View
{
    public interface IScreenWindow : IView<ScreenWindowPresenter>
    {
        event MouseEventHandler MouseLeftClick;

        event MouseEventHandler MouseLeftUp;

        event MouseEventHandler FormMouseMove;

        Color BColor { get; set; }

        void UpdateForm();

        void AddControl(Control control);
    }
}