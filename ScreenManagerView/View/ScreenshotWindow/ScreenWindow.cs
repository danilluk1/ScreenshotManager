using MetroFramework.Forms;
using ScreenManagerBL.Core;
using ScreenManagerBL.Model.ScreenStrategy;
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
            
            SetStyle(ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint, true);
            UpdateStyles();         
        }
        public ScreenWindowPresenter Presenter { private get; set; }
        public Color BColor { get => BackColor; set => BackColor = value; }

        public event MouseEventHandler MouseLeftClick;
        public event MouseEventHandler MouseLeftUp;
        public event MouseEventHandler FormMouseMove;

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
        private void ScreenWindow_MouseMove(object sender, MouseEventArgs e)
        {
            FormMouseMove?.Invoke(this, e);
        }
        public void Down()
        {
            this.Close();
        }

        public void Open()
        {
            this.Show();
        }
        public void UpdateForm()
        {
            this.Refresh();
        }

        public void AddControl(Control control)
        {
            Controls.Add(control);
        }
    }
}
