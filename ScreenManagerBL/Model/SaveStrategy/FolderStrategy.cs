using System;
using System.Drawing;
using System.IO;
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

        public void Save()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                sfd.Filter = "Joint Photographic Experts Group .jpg|*.jpg;|Portable Network Graphics .png| *.png |Bitmap Picture .bmp| *.bmp";
                sfd.FileName = "Снимок";
                sfd.Title = "Сохрание";
                sfd.InitialDirectory = "Images";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Image.Save(sfd.FileName);
                }
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                MessageBox.Show("Не удалось сохранить файл!");
                File.Delete(sfd.FileName);
            }
        }
    }
}