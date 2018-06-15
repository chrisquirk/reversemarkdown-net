
using System;

using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Article
        : ConverterBase
    {
		public Article(Converter converter)
			: base(converter)
		{
			this.Converter.Register("article", this);
			this.Converter.Register("main", this);
			this.Converter.Register("fieldset", this);
			this.Converter.Register("caption", this);
		}

		public override string Convert(HtmlNode node)
		{
			return Environment.NewLine + this.TreatChildren(node).Trim() + Environment.NewLine;
		}
    }
}
