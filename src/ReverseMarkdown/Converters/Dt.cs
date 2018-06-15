
using System;

using HtmlAgilityPack;

namespace ReverseMarkdown.Converters
{
    public class Dt : ConverterBase
    {
        public Dt(Converter converter) : base(converter)
        {
            converter.Register("dt", this);
            converter.Register("dd", this);
        }

        public override string Convert(HtmlNode node)
        {
            return Environment.NewLine + TreatChildren(node) + Environment.NewLine;
        }
    }
}
