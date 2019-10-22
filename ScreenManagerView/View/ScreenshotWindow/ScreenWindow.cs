using MetroFramework.Forms;
using ScreenManagerBL.Presenter;
using ScreenManagerBL.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenManagerView.View.ScreenshotWindow
{
    public partial class ScreenWindow : MetroForm, IScreenWindow
    {
        public ScreenWindow()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                                                                        ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        public ScreenWindowPresenter Presenter { private get; set; }

        public event MouseEventHandler MouseLeftClick;
        public event MouseEventHandler MouseLeftUp;
        public event PaintEventHandler PaintRect;

        private void ScreenWindow_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    MouseLeftClick?.Invoke(this, e);
                    break;
            }
        }
        private void ScreenWindow_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    MouseLeftUp?.Invoke(this, e);
                    break;
            }
        }
        private void ScreenWindow_Paint(object sender, PaintEventArgs e)
        {
            PaintRect?.Invoke(this, e);
        }
        public void Down()
        {
            this.Close();
        }

        public void Open()
        {
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
