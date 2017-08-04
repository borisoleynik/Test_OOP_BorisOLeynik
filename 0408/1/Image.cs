using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Image : File
    {
        private string _resolution;

        
        public Image(string Resolution, string FileName, string FileSize): base (FileName, FileSize)
        {
            _resolution = Resolution;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("{0} - Resolution", _resolution);
        }
    }
}
