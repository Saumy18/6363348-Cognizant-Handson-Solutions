using FactoryMethodPatternExample.Documents;

namespace FactoryMethodPatternExample.Factories
{
    public class WordDocFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDoc();
        }
    }
}
