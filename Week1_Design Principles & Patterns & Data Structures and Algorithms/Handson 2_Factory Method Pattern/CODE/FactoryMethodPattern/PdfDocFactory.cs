using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    public class PdfDocFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDoc();
        }
    }
}
