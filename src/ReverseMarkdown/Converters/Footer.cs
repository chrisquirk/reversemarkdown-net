
using System;

using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Footer
        : ConverterBase
    {
		public Footer(Converter converter)
			: base(converter)
		{
			this.Converter.Register("footer", this);
		}

		public override string Convert(HtmlNode node)
		{
			return Environment.NewLine + this.TreatChildren(node).Trim() + Environment.NewLine;
		}
    }
}
