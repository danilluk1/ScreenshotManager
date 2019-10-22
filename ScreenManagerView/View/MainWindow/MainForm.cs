using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScreenManagerBL.Presenter;
using ScreenManagerBL.View;
using ScreenManagerView.View.ScreenshotWindow;

namespace ScreenManagerView
{
    public partial class MainForm : MetroForm, IMainWindow
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainFormPresenter Presenter { private get; set; }

        public event EventHandler NewScrClick;

        private void NewscreenButton_Click(object sender, EventArgs e)
        {
            int width = 0;
            int heigth = 0;
            for(int i = 0; i < Screen.AllScreens.Length; i++)
            {
                Screen screen = Screen.AllScreens[i];
                width += screen.Bounds.Width;
                heigth = screen.Bounds.Height;
            }
            var presenter = new ScreenWindowPresenter(new ScreenWindow() 
            {
                Width = width,
                Height = heigth,
            }, this);
        }
        public void Down()
        {
            this.Close();
        }

        public void MakeInvisible()
        {
            Visible = false;
        }

        public void MakeVisible()
        {
            Visible = true;
        }

        public void Open()
        {
            this.Show();
        }
    }
}
