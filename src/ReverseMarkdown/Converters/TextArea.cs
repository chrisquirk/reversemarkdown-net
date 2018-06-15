
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class TextArea
        : ConverterBase
    {
		public TextArea(Converter converter)
			: base(converter)
		{
			this.Converter.Register("textarea", this);
		}

		public override string Convert(HtmlNode node)
		{
            return "";
		}
    }
}
