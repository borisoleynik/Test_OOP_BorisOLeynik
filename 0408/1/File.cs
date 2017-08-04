using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
     class File
    {
        private string _fileName;
        private string _fileSize;
        public File (string FileName, string FileSize)
        {
            _fileName = FileName;
            _fileSize = FileSize;
        }
        public virtual void Print()
        {
            Console.WriteLine(@"
{0,20} - Name 
{1,20} - Size", _fileName, _fileSize.Trim(new char[] { '(', ')' }));
        }
    }
}
