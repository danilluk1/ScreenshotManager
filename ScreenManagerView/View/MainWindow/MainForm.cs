using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScreenManagerBL.Core;
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
        public Image Screenshot { get => imageBox.BackgroundImage; set => imageBox.BackgroundImage = value; }

        public event EventHandler NewScrClick;
        public event EventHandler PreShowClick;

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
        private void screenButton_Click(object sender, EventArgs e)
        {
            try
            {
                int width = 0;
                int heigth = 0;
                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    Screen screen = Screen.AllScreens[i];
                    width += screen.Bounds.Width;
                    heigth = screen.Bounds.Height;
                }
                if (modeComboBox.SelectedItem.ToString().Equals("Часть экрана"))
                {
                    var presenter = new ScreenWindowPresenter(new ScreenWindow()
                    {
                        Width = width,
                        Height = heigth,
                    }, this, new ScreenManager(Modes.PartScreen));
                }
                else if (modeComboBox.SelectedItem.ToString().Equals("Экран"))
                {
                    var presenter = new ScreenWindowPresenter(new ScreenWindow()
                    {
                        Width = width,
                        Height = heigth,
                    }, this, new ScreenManager(Modes.FullScreen));
                }
                if (modeComboBox.SelectedItem.ToString().Equals("Окно"))
                {

                }
            }
            catch (NullReferenceException) { }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (imageBox.BackgroundImage != null)
            {
                imageBox.BackgroundImage.Save("image", ImageFormat.Png);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            var w = Width;
            var h = Height;
            if (imageBox.Width != Width - 20)
            {
                Width = Screen.PrimaryScreen.Bounds.Width / 2;
                Height = Screen.PrimaryScreen.Bounds.Height / 2;
                imageBox.Width = Width - 20;
                imageBox.Height = Height - 45;

            }
            else
            {
                Width = 400;
                Height = 150;
                imageBox.Width = 0;
                imageBox.Height = 0;
            }

        }

        private void themeSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            if (themeSwitcher.Checked)
            {
                Theme = MetroFramework.MetroThemeStyle.Dark;
                themeSwitcher.Theme = MetroFramework.MetroThemeStyle.Dark;
                screenButton.Theme = MetroFramework.MetroThemeStyle.Dark;
                modeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
                showButton.Theme = MetroFramework.MetroThemeStyle.Dark;
                saveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
                closeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
                backPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                Theme = MetroFramework.MetroThemeStyle.Light;
                themeSwitcher.Theme = MetroFramework.MetroThemeStyle.Light;
                screenButton.Theme = MetroFramework.MetroThemeStyle.Light;
                modeComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
                showButton.Theme = MetroFramework.MetroThemeStyle.Light;
                saveButton.Theme = MetroFramework.MetroThemeStyle.Light;
                closeButton.Theme = MetroFramework.MetroThemeStyle.Light;
                backPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Down();
        }
    }
}
