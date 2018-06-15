
using System.Linq;

using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Strong
		: ConverterBase
	{
		public Strong(Converter converter)
			: base(converter)
		{
			this.Converter.Register("strong", this);
			this.Converter.Register("b", this);
			this.Converter.Register("u", this);
		}

		public override string Convert(HtmlNode node)
		{
			string content = this.TreatChildren(node);
			if (this.Converter.Config.TextNotMarkdown || string.IsNullOrEmpty(content.Trim()) || AlreadyBold(node))
			{
				return content;
			}
			else
			{
                return "**" + content.Trim() + "**";
			}
		}

		private bool AlreadyBold(HtmlNode node)
		{
			return node.Ancestors("strong").Count() > 0 || node.Ancestors("b").Count() > 0;
		}
	}
}
