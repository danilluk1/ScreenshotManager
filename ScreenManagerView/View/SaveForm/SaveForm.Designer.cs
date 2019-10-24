namespace ScreenManagerView.View.SaveForm
{
    partial class SaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterNameLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.formatComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pathBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Location = new System.Drawing.Point(8, 37);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(89, 19);
            this.enterNameLabel.TabIndex = 0;
            this.enterNameLabel.Text = "Введите имя:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(191, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(219, 175);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.ItemHeight = 23;
            this.formatComboBox.Items.AddRange(new object[] {
            "Jpeg",
            "Png",
            "Bmp"});
            this.formatComboBox.Location = new System.Drawing.Point(103, 63);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(191, 29);
            this.formatComboBox.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Формат:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(103, 98);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(191, 23);
            this.pathBox.TabIndex = 5;
            this.pathBox.Text = "Щелчёк для откытия диалога";
            this.pathBox.Click += new System.EventHandler(this.pathComboBox_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(59, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Путь:";
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.enterNameLabel);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "SaveForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel enterNameLabel;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private System.Windows.Forms.Button saveButton;
        private MetroFramework.Controls.MetroComboBox formatComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox pathBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}