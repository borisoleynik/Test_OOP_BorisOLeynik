using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class TextFile : File
    {
        private string _content;
        public TextFile(string Content, string FileName, string FileSize) : base (FileName,FileSize)
        {
            _content = Content;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("{0} - Content", _content);  
        }

    }
}
