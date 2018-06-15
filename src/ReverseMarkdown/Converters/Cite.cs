
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Cite
        : ConverterBase
    {
        public Cite(Converter converter)
            : base(converter)
        {
            this.Converter.Register("cite", this);
        }

        public override string Convert(HtmlNode node)
        {
            return this.TreatChildren(node);
        }
    }
}
