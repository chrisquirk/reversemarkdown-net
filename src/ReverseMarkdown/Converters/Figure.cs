
using System;

using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Figure
        : ConverterBase
    {
		public Figure(Converter converter)
			: base(converter)
		{
			this.Converter.Register("figure", this);
			this.Converter.Register("figcaption", this);
		}

		public override string Convert(HtmlNode node)
		{
            return Environment.NewLine + TreatChildren(node).Trim() + Environment.NewLine;
		}
    }
}
