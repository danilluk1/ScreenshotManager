using MetroFramework.Forms;
using ScreenManagerBL.Core;
using ScreenManagerBL.Model.SaveStrategy;
using ScreenManagerBL.Presenter;
using ScreenManagerBL.View;
using ScreenManagerView.View.ScreenshotWindow;
using ScreenManagerView.View.ScreenShower;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenManagerView
{
    public partial class MainForm : MetroForm, IMainWindow
    {
        private SaveContext context;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainFormPresenter Presenter { private get; set; }
        public Bitmap Screenshot { get; set; }

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
            if (Screenshot != null)
            {
                saveButton.Enabled = true;
            }
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
                    }, this, Modes.PartScreen);
                }
                if (modeComboBox.SelectedItem.ToString().Equals("Экран"))
                {
                    var presenter = new ScreenWindowPresenter(new ScreenWindow()
                    {
                        Width = width,
                        Height = heigth,
                    }, this, Modes.FullScreen);
                }
                if (modeComboBox.SelectedItem.ToString().Equals("Окно"))
                {
                }
            }
            catch (NullReferenceException) { }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            context = new SaveContext(new FolderStrategy(Screenshot));
            context.DoSave();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            var shower = new ScreenShower(Screenshot);
            shower.Show();
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