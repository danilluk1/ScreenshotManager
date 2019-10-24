using ScreenManagerBL.Model.SaveStrategy;
using ScreenManagerBL.View;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenManagerBL.Presenter
{
    public class SaveFormPresenter : BasePresenter
    {
        ISaveView View;
        SaveContext Context;
        public SaveFormPresenter(ISaveView view, SaveContext cont)
        {
            View = view;
            Context = cont;
            view.PathBoxClick += View_PathBoxClick;
            view.SaveButtonClick += View_SaveButtonClick;
            view.Open();
        }
        private void View_SaveButtonClick(object sender, EventArgs e)
        {
            Context.ContextStrategy.SaveFormat = ImageFormat.Png;
            Context.ContextStrategy.FileName = View.PathText + "\\" + View.NameText;
            var format = View.ComboSelectedItem;
            if (format.Equals("Jpeg"))
            {
                Context.ContextStrategy.SaveFormat = ImageFormat.Jpeg;
            }
            if (format.Equals("Png"))
            {
                Context.ContextStrategy.SaveFormat = ImageFormat.Png;
            }
            if (format.Equals("Bmp"))
            {
                Context.ContextStrategy.SaveFormat = ImageFormat.Bmp;
            }
            Context.DoSave();
        }
        private void View_PathBoxClick(object sender, EventArgs e)
        {
            var dia = new FolderBrowserDialog();
            if(dia.ShowDialog() == DialogResult.OK)
            {
                var res = dia.SelectedPath;
                Context.ContextStrategy.FileName = res;
                View.PathText = res;
            }

        }
    }
}
