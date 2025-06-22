using System;

namespace FactoryMethodPatternExample.Documents
{
    public class ExcelDoc : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel Document.");
        }
    }
}
