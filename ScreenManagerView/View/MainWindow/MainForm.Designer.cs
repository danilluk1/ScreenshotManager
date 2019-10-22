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
            this.newscreenButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // newscreenButton
            // 
            this.newscreenButton.Location = new System.Drawing.Point(5, 10);
            this.newscreenButton.Name = "newscreenButton";
            this.newscreenButton.Size = new System.Drawing.Size(75, 23);
            this.newscreenButton.TabIndex = 0;
            this.newscreenButton.Text = "New Screen";
            this.newscreenButton.Click += new System.EventHandler(this.NewscreenButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.newscreenButton);
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton newscreenButton;
    }
}

