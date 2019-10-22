using ScreenManagerBL.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenManagerBL.View
{
    public interface IMainWindow : IView<MainFormPresenter>
    {
        event EventHandler NewScrClick;
        void MakeInvisible();
        void MakeVisible();
    }
}
