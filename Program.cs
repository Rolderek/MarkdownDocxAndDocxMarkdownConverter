using System;
using System.IO;
using MarkdownDocxConverter.Converters;

public class Program
{
    //ezt használtam: https://github.com/manfromarce/DocSharp/wiki/Convert-DOCX-documents
    private static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Usage: converter <inputPath> <outputFolder> <docx|md>");
            return;
        }

        string input = args[0];
        string outputFolder = args[1];
        string format = args[2];

        //na így már van kimeneti filePath rendesen
        string fileName = Path.GetFileNameWithoutExtension(input);
        string extension = format == "docx" ? ".docx" : ".md";
        string output = Path.Combine(outputFolder, fileName + extension);

        IConverter converter;

        if (format == "docx")
        {
            converter = new MarkdownToDocxConverter(input, output);
        }
        else
        {
            converter = new DocxToMarkdownConverter(input, output);
        }

        converter.Convert(input, output);
    }
}