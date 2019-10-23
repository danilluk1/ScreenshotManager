namespace ScreenManagerView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.modeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.showButton = new MetroFramework.Controls.MetroButton();
            this.themeSwitcher = new MetroFramework.Controls.MetroToggle();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.backPanel = new MetroFramework.Controls.MetroPanel();
            this.screenButton = new MetroFramework.Controls.MetroButton();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.ItemHeight = 23;
            this.modeComboBox.Items.AddRange(new object[] {
            "Экран",
            "Часть экрана",
            "Окно"});
            this.modeComboBox.Location = new System.Drawing.Point(44, 1);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(112, 29);
            this.modeComboBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(153, 1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(69, 29);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(221, 1);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(56, 29);
            this.showButton.TabIndex = 7;
            this.showButton.Text = "Показать";
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // themeSwitcher
            // 
            this.themeSwitcher.AutoSize = true;
            this.themeSwitcher.Location = new System.Drawing.Point(283, 7);
            this.themeSwitcher.Name = "themeSwitcher";
            this.themeSwitcher.Size = new System.Drawing.Size(80, 17);
            this.themeSwitcher.TabIndex = 8;
            this.themeSwitcher.Text = "Off";
            this.themeSwitcher.UseVisualStyleBackColor = true;
            this.themeSwitcher.CheckedChanged += new System.EventHandler(this.themeSwitcher_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(369, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.closeButton);
            this.backPanel.Controls.Add(this.themeSwitcher);
            this.backPanel.Controls.Add(this.screenButton);
            this.backPanel.Controls.Add(this.showButton);
            this.backPanel.Controls.Add(this.modeComboBox);
            this.backPanel.Controls.Add(this.saveButton);
            this.backPanel.HorizontalScrollbarBarColor = true;
            this.backPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.backPanel.HorizontalScrollbarSize = 10;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(402, 33);
            this.backPanel.TabIndex = 10;
            this.backPanel.VerticalScrollbarBarColor = true;
            this.backPanel.VerticalScrollbarHighlightOnWheel = false;
            this.backPanel.VerticalScrollbarSize = 10;
            // 
            // screenButton
            // 
            this.screenButton.Location = new System.Drawing.Point(0, 1);
            this.screenButton.Name = "screenButton";
            this.screenButton.Size = new System.Drawing.Size(42, 29);
            this.screenButton.TabIndex = 3;
            this.screenButton.Text = "Скрин";
            this.screenButton.Click += new System.EventHandler(this.screenButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Location = new System.Drawing.Point(3, 36);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(0, 0);
            this.imageBox.TabIndex = 12;
            this.imageBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 150);
            this.ControlBox = false;
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.backPanel);
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox modeComboBox;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroButton showButton;
        private MetroFramework.Controls.MetroToggle themeSwitcher;
        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroPanel backPanel;
        private MetroFramework.Controls.MetroButton screenButton;
        private System.Windows.Forms.PictureBox imageBox;
    }
}

