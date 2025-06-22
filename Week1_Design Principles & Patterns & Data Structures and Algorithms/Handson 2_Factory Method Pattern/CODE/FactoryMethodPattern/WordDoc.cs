using System;

namespace FactoryMethodPatternExample.Documents
{
    public class WordDoc : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word Document.");
        }
    }
}
