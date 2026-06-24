using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownDocxConverter.Converters
{
    public interface IConverter
    {
        //séma
        void Convert(string inputFile, string outputFile);
    }
}
