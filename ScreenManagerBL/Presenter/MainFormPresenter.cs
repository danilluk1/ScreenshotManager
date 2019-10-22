using ScreenManagerBL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenManagerBL.Presenter
{
    public class MainFormPresenter : BasePresenter
    {
        private IMainWindow view;
        public MainFormPresenter(IMainWindow view)
        {
            this.view = view;
            view.Open();
        }
    }
}
