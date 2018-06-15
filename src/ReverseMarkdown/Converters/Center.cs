
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Center
        : ConverterBase
    {
		public Center(Converter converter)
			: base(converter)
		{
			this.Converter.Register("center", this);
		}

		public override string Convert(HtmlNode node)
		{
            return TreatChildren(node).Trim();
		}
    }
}
