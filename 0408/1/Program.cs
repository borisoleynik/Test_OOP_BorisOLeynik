using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = @"Text: file.txt(6B); Some string content
Image: img.bmp(19MB); 1920х1080
Text:data.txt(12B); Another string
Text:data1.txt(7B); Yet another string
Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m".Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < text.Length; i++)
            {
                var tmp = text[i].Split(':', ';', '(');
                if(tmp[0] == "Text")
                {
                    TextFile testText = new TextFile(tmp[3], tmp[1], tmp[2]);
                    testText.Print();
                }
                if(tmp[0] == "Image")
                {
                    Image testImage = new Image(tmp[3], tmp[1], tmp[2]);
                    testImage.Print();
                }
                if(tmp[0] == "Movie")
                {
                    Movie testImage = new Movie(tmp[3], tmp[4], tmp[1], tmp[2]);
                    testImage.Print();
                }
            }
            


        }
    }
}
