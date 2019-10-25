using ScreenManagerBL.Presenter;
using System;
using System.Windows.Forms;

namespace ScreenManagerView
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new MainForm();
            var presenter = new MainFormPresenter(view);
            Application.Run(view);
        }
    }
}