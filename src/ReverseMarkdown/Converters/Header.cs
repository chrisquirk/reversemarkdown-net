
using System;

using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Header
        : ConverterBase
    {
		public Header(Converter converter)
			: base(converter)
		{
			this.Converter.Register("header", this);
		}

		public override string Convert(HtmlNode node)
		{
			return Environment.NewLine + this.TreatChildren(node).Trim() + Environment.NewLine;
		}
    }
}
