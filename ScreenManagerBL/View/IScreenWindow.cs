using ScreenManagerBL.Presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenManagerBL.View
{
    public interface IScreenWindow : IView<ScreenWindowPresenter>
    {
        event MouseEventHandler MouseLeftClick;
        event MouseEventHandler MouseLeftUp;
        event PaintEventHandler PaintRect;
        event MouseEventHandler FormMouseMove;
        event EventHandler FormLoad;
        Color BColor { get; set; }
        void UpdateForm();
        void AddControl(Control control);
    }
}
