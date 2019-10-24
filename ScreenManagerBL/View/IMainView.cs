using ScreenManagerBL.Model.SaveStrategy;
using ScreenManagerBL.Presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenManagerBL.View
{
    public interface IMainWindow : IView<MainFormPresenter>
    {
        event EventHandler NewScrClick;
        event EventHandler PreShowClick;
        Bitmap Screenshot { get; set; }
        void MakeInvisible();
        void MakeVisible();
    }
}
