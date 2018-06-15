
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class NoScript
        : ConverterBase
    {
		public NoScript(Converter converter)
			: base(converter)
		{
			this.Converter.Register("noscript", this);
			this.Converter.Register("link", this);
		}

		public override string Convert(HtmlNode node)
		{
            return "";
		}
    }
}
