using MetroFramework.Forms;
using System.Drawing;

namespace ScreenManagerView.View.ScreenShower
{
    public partial class ScreenShower : MetroForm
    {
        public ScreenShower(Bitmap bmp)
        {
            InitializeComponent();
            this.Width = bmp.Width;
            this.Height = bmp.Height;
            imgBox.BackgroundImage = bmp;
        }
    }
}