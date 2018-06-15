
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Form
        : ConverterBase
    {
		public Form(Converter converter)
			: base(converter)
		{
			this.Converter.Register("form", this);
			this.Converter.Register("input", this);
			this.Converter.Register("button", this);
			this.Converter.Register("select", this);
		}

		public override string Convert(HtmlNode node)
		{
            return "";
		}
    }
}
