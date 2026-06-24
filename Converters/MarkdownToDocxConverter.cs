using System;
using System.IO;
using DocSharp.Markdown;

namespace MarkdownDocxConverter.Converters
{
    public class MarkdownToDocxConverter : IConverter
    {
        public string inputFile { get; set; }
        public string outputFile { get; set; }

        public MarkdownToDocxConverter()
        {
            this.inputFile = "";
            this.outputFile = "";
        }

        public MarkdownToDocxConverter(string i, string o)
        {
            this.inputFile = i;
            this.outputFile = o;
        }

        public void Convert(string inputFile, string outputFile)
        {
            try
            {
                var markdown = MarkdownSource.FromFile(inputFile);
                var converter = new MarkdownConverter()
                {
                    ImagesBaseUri = Path.GetDirectoryName(inputFile), //elvileg képet is tud, ezt nem teszteltem
                };
                converter.ToDocx(markdown, outputFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}