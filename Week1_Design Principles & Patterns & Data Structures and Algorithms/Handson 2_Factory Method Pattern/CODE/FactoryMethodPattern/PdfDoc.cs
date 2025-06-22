using System;

namespace FactoryMethodPatternExample.Documents
{
    public class PdfDoc : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document.");
        }
    }
}
