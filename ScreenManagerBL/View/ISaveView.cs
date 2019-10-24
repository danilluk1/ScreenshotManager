using ScreenManagerBL.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenManagerBL.View
{
    public interface ISaveView : IView<SaveFormPresenter>
    {
        string NameText { get; set; }
        string PathText { get; set; }
        string ComboSelectedItem { get; set; }

        event EventHandler PathBoxClick;
        event EventHandler SaveButtonClick;
    }
}
