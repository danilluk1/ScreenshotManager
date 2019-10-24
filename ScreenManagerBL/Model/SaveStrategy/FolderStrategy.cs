using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenManagerBL.Model.SaveStrategy
{
    public class FolderStrategy : ISaveStrategy
    {
        public FolderStrategy(Bitmap img)
        {
            Image = img ?? throw new ArgumentNullException(nameof(img));
        }
        public Bitmap Image { get; set; }
        public ImageFormat SaveFormat { get; set; }
        public string FileName { get; set; }

        public void Save()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                sfd.DefaultExt = SaveFormat.ToString().ToLower();
                sfd.FileName = "Снимок";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Image.Save(sfd.FileName, SaveFormat);
                }
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                MessageBox.Show("Не удалось сохранить файл!");
                File.Delete(FileName);
            }
        }
    }
}
