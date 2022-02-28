using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAZZIO
{
    internal class Functions
    {
        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            string dir = @"C:\Scripts";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            DirectoryInfo dinfo = new DirectoryInfo(dir);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }
    }
}
