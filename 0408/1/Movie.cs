using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Movie : File
    {
        private string _resolution;
        private string _lenght;

        public Movie (string Resolution, string Lenght, string FileName, string FileSize): base (FileName, FileSize)
            {
            _resolution = Resolution;
            _lenght = Lenght;
            }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("{0} - Resolution {1} - Lenght", _resolution,_lenght);
        }
    }
}
