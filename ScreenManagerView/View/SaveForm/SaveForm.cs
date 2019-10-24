using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScreenManagerBL.Presenter;
using ScreenManagerBL.View;

namespace ScreenManagerView.View.SaveForm
{
    public partial class SaveForm : MetroForm, ISaveView
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        public string NameText { get => nameTextBox.Text; set => nameTextBox.Text = value; }
        public string ComboSelectedItem { get => formatComboBox.SelectedItem.ToString(); set => throw new NotImplementedException(); }
        public string PathText { get => pathBox.Text; set => pathBox.Text = value; }
        public SaveFormPresenter Presenter { private get; set; }

        public event EventHandler PathBoxClick;
        public event EventHandler SaveButtonClick;

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void pathComboBox_Click(object sender, EventArgs e)
        {
            PathBoxClick?.Invoke(this, EventArgs.Empty);
        }

        public void Open()
        {
            this.Show();
        }

        public void Down()
        {
            this.Close();
        }
    }
}
