using ScreenManagerBL.Presenter;

namespace ScreenManagerBL.View
{
    public interface IView<T> where T : BasePresenter
    {
        T Presenter { set; }

        void Open();

        void Down();
    }
}