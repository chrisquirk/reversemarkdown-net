
using System;

using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Section
		: ConverterBase
	{
		public Section(Converter converter)
			: base(converter)
		{
			this.Converter.Register("section", this);
		}

		public override string Convert(HtmlNode node)
		{
			return Environment.NewLine + this.TreatChildren(node).Trim() + Environment.NewLine;
		}
	}
}
