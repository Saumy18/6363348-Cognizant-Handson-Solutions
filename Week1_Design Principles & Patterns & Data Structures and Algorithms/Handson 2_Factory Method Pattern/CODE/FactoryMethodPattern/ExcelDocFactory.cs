using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    public class ExcelDocFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDoc();
        }
    }
}
