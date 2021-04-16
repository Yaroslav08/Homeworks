using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLaba7
{
    public class TreeFolder
    {
        private static Stack<string> folders;

        public TreeFolder(string path)
        {
            folders = new Stack<string>();
            folders.Push(path);
        }

        public void CreateTreeFolders(long numberFolders)
        {
            if (numberFolders != 0)
            {
                string folder = folders.Pop();
                string path = folder + "\\" + Guid.NewGuid().ToString("N");
                Directory.CreateDirectory(path);
                folders.Push(path);
                CreateTreeFolders(numberFolders - 1);
            }
        }
    }
}
