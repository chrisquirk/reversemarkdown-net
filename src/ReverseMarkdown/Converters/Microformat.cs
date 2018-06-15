
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Microformat : ConverterBase
    {
        public Microformat(Converter c) : base(c)
        {
			this.Converter.Register("address", this);
			this.Converter.Register("time", this);
        }
		public override string Convert(HtmlNode node)
		{
			return this.TreatChildren(node).Trim();
		}
    }
}
