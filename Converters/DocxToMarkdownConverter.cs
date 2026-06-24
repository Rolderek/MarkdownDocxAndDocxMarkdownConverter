using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocSharp.Docx;

namespace MarkdownDocxConverter.Converters
{
    public class DocxToMarkdownConverter : IConverter
    {
        public string inputFile { get; set; }
        public string outputFile { get; set; }

        public DocxToMarkdownConverter()
        {
            this.inputFile = "";
            this.outputFile = "";
        }

        public DocxToMarkdownConverter(string i, string o)
        {
            this.inputFile = i;
            this.outputFile = o;
        }

        public void Convert(string inputFile, string outputFile) 
        {
            //nem biztos hogy a leg elegánsabb, de működik
            try
            {
                var converter = new DocSharp.Docx.DocxToMarkdownConverter();
                converter.Convert(inputFile, outputFile);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
    }
}
