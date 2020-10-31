using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSetdata
{
    public class FileSetdata
    {
        public string FileName { get; private set; }
        public string FolderName { get; private set; }
        public string Extension { get; private set; }

        public FileSetdata() { }
        public FileSetdata(string filename, string foldername, string extension)
        {
            FileName = filename;
            FolderName = foldername;
            Extension = extension;
        }
    }
}
