
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Fonts : ConverterBase
    {
        public Fonts(Converter converter)
            : base(converter)
        {
            this.Converter.Register("small", this);
            this.Converter.Register("big", this);
            this.Converter.Register("sub", this);
            this.Converter.Register("sup", this);
            this.Converter.Register("font", this);
            this.Converter.Register("tt", this);
            this.Converter.Register("abbr", this);
            this.Converter.Register("acronym", this);
            this.Converter.Register("ins", this);
            this.Converter.Register("del", this);
            this.Converter.Register("nobr", this);
            this.Converter.Register("var", this);
            this.Converter.Register("noindex", this);
        }

        public override string Convert(HtmlNode node)
        {
            return TreatChildren(node);
        }
    }
}
