
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Meta
        : ConverterBase
    {
		public Meta(Converter converter)
			: base(converter)
		{
			this.Converter.Register("meta", this);
		}

		public override string Convert(HtmlNode node)
		{
            return "";
		}
    }
}
