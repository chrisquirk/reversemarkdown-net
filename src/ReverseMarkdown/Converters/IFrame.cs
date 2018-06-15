
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class IFrame
        : ConverterBase
    {
		public IFrame(Converter converter)
			: base(converter)
		{
			this.Converter.Register("iframe", this);
		}

		public override string Convert(HtmlNode node)
		{
            return "";
		}
    }
}
