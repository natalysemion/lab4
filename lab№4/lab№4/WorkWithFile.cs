using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class WorkWithFile
    {
        public static bool SaveFile()
        {
            bool _saved = false;
            if (string.IsNullOrEmpty(Helper.path))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    InitialDirectory = @"D:\",
                    Title = "Save",
                    DefaultExt = "json",
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Helper.path = saveFileDialog.FileName;
                    JsonAction.SerializeToJson(Helper.path, Helper.biathletes);
                    _saved = true;
                }
            }
            return _saved;
        }
        public static void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Open",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "json"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Helper.path = openFileDialog.FileName;
                    Helper.biathletes = JsonAction.DeserialiseFromJson(Helper.path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static bool CreateFile()
        {
            bool saved = false;
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Create",

                Filter = "json files (*.json)|*.json;",
                DefaultExt = "json"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Helper.path = saveFileDialog.FileName;
                JsonAction.SerializeToJson(Helper.path, Helper.biathletes);
                saved = true;
            }
            return saved;
        }
    }
}
