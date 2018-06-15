
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Pictures
        : ConverterBase
    {
		public Pictures(Converter converter)
			: base(converter)
		{
			this.Converter.Register("svg", this);
			this.Converter.Register("picture", this);
			this.Converter.Register("map", this);
			this.Converter.Register("style", this);
		}

		public override string Convert(HtmlNode node)
		{
            return "";
		}
    }
}
