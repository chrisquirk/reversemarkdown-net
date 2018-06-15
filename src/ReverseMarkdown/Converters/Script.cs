using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Script : ConverterBase
    {
        public Script(Converter converter)
            : base(converter)
        {
            this.Converter.Register("script", this);
        }

        public override string Convert(HtmlNode node)
        {
            return "";
        }
    }
}
