using ScreenManagerBL.Core;
using ScreenManagerBL.Model.ScreenStrategy;
using ScreenManagerBL.View;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenManagerBL.Presenter
{
    public class ScreenWindowPresenter : BasePresenter
    {
        private IScreenWindow view;
        private IMainWindow menuView;
        private IScreenManager manager;
        private int startX = 0;
        private int startY = 0;
        private int endX = 0;
        private int endY = 0;
        private bool IsLeftButtonPressed = false;
        private PictureBox imageBox;
        private Bitmap image = null;

        public ScreenWindowPresenter(IScreenWindow view, IMainWindow mainV, Modes mode)
        {
            this.view = view;
            this.menuView = mainV;
            view.MouseLeftClick += View_MouseLeftClick;
            view.MouseLeftUp += View_MouseLeftUp;
            view.FormMouseMove += View_FormMouseMove;
            view.Open();
            manager = new ScreenManager();
            if (mode == Modes.FullScreen)
            {
                Screen scr = Screen.PrimaryScreen;
                view.BColor = Color.Black;
                menuView.MakeInvisible();
                image = manager.DoScr(new FullScreenStrategy(),
                                  scr.Bounds.Width,
                                  scr.Bounds.Height,
                                  0,
                                  0);
                PrepareFormAfterScreen();
            }
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
                else if (startX > endX && startY < endY)
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
                if (startX < endX && startY > endY)
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

            PrepareFormToScreen();
            image = manager.DoScr(new PartScreenStrategy(), imageBox.Width, imageBox.Height, imageBox.Left, imageBox.Top);
            PrepareFormAfterScreen();
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
                Width = 0,
                Height = 0,
                BackColor = Color.Black
            };
            view.AddControl(imageBox);
        }

        public void PrepareFormToScreen()
        {
            imageBox.BackColor = Color.Transparent;
            view.BColor = Color.Black;
        }

        public void PrepareFormAfterScreen()
        {
            menuView.Screenshot = image;
            view.Down();
            menuView.MakeVisible();
        }
    }
}