using ScreenManagerBL.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenManagerBL.View
{
    public interface IView<T> where T : BasePresenter
    {
        T Presenter { set; }
        void Open();
        void Down();
    }
}
