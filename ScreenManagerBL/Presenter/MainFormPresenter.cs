using ScreenManagerBL.View;

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