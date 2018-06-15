
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Label
        : ConverterBase
    {
		public Label(Converter converter)
			: base(converter)
		{
			this.Converter.Register("label", this);
		}

		public override string Convert(HtmlNode node)
		{
            return TreatChildren(node).Trim();
		}
    }
}
