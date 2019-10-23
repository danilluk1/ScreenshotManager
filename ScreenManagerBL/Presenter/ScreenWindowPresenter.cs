using ScreenManagerBL.View;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using ScreenManagerBL.Core;

namespace ScreenManagerBL.Presenter
{
    public class ScreenWindowPresenter : BasePresenter
    {
        private IScreenWindow view;
        private IMainWindow menuView;
        private readonly IScreenManager manager;
        private static int startX = 0;
        private static int startY = 0;
        private static int endX = 0;
        private static int endY = 0;
        private static bool IsLeftButtonPressed = false;
        private static PictureBox imageBox;
        public ScreenWindowPresenter(IScreenWindow view, IMainWindow mainV, IScreenManager m)
        {
            this.view = view;
            this.menuView = mainV;
            manager = m;
            view.MouseLeftClick += View_MouseLeftClick;
            view.MouseLeftUp += View_MouseLeftUp;
            view.FormMouseMove += View_FormMouseMove;
            view.PaintRect += View_PaintRect;
            view.Open();
            if(m.Mode == Modes.FullScreen)
            {
                menuView.MakeInvisible();
                view.BColor = Color.Black;
                Bitmap b = m.MakeScreen(Screen.PrimaryScreen);
                mainV.Screenshot = b;
                view.Down();
                menuView.MakeVisible();
            }
        }

        private void View_PaintRect(object sender, PaintEventArgs e)
        {
        }

        private void View_FormMouseMove(object sender, MouseEventArgs e)
        {
            if (IsLeftButtonPressed)
            {
                var height = 0;
                var width = 0;
                endX = e.X;
                endY = e.Y;
                if (startX < endX && startY < endY)
                {
                    width = endX - startX;
                    height = endY - startY;
                }
                else if(startX > endX && startY < endY)
                {
                    width = startX - endX;
                    imageBox.Top = startY;
                    imageBox.Left = endX;
                    height = endY - startY;
                }
                if (startY > endY && startX >= endX)
                {
                    height = startY - endY;
                    imageBox.Top = endY;
                    imageBox.Left = endX;
                    width = startX - endX;
                }
                if(startX < endX && startY > endY)
                {
                    height = startY - endY;
                    width = endX - startX;
                    imageBox.Top = endY;
                    imageBox.Left = startX;
                }
                imageBox.Width = width;
                imageBox.Height = height;
            }
        }
        private void View_MouseLeftUp(object sender, MouseEventArgs e)
        {
            IsLeftButtonPressed = false;
            imageBox.BackColor = Color.Transparent;
            view.BColor = Color.Black;
            switch (manager.Mode)
            {
                case Modes.PartScreen:
                    manager.MakeScreen(imageBox);
                    break;
            }
            Bitmap b = manager.MakeScreen(imageBox);
            menuView.Screenshot = b;
            view.Down();
            menuView.MakeVisible();
        }

        private void View_MouseLeftClick(object sender, MouseEventArgs e)
        {
            IsLeftButtonPressed = true;
            startX = e.X;
            startY = e.Y;
            menuView.MakeInvisible();
            imageBox = new PictureBox
            {
                Top = startY,
                Left = startX,
                Width = 200,
                Height = 200,
                BackColor = Color.Black
            };
            view.AddControl(imageBox);
        }
    }
}
