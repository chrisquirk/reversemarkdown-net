
using System;

using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Nav
        : ConverterBase
    {
		public Nav(Converter converter)
			: base(converter)
		{
			this.Converter.Register("nav", this);
			this.Converter.Register("menu", this);
		}

		public override string Convert(HtmlNode node)
		{
			return Environment.NewLine + this.TreatChildren(node).Trim() + Environment.NewLine;
		}
    }
}
