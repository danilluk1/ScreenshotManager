using ScreenManagerBL.View;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenManagerBL.Presenter
{
    public class ScreenWindowPresenter : BasePresenter
    {
        private IScreenWindow view;
        private IMainWindow menuView;
        private static int startX = 0;
        private static int startY = 0;
        private static int endX = 0;
        private static int endY = 0;
        public ScreenWindowPresenter(IScreenWindow view, IMainWindow mainV)
        {
            this.view = view;
            this.menuView = mainV;
            view.MouseLeftClick += View_MouseLeftClick;
            view.MouseLeftUp += View_MouseLeftUp;
            view.PaintRect += View_PaintRect;
            view.Open();
        }

        private void View_PaintRect(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Gray, 4), startX, startY, endX - startX, endY - startY);
        }

        private void View_MouseLeftUp(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;
            menuView.MakeVisible();
        }

        private void View_MouseLeftClick(object sender, MouseEventArgs e)
        {
            menuView.MakeInvisible();
            startX = e.X;
            startY = e.Y;
        }
    }
}
