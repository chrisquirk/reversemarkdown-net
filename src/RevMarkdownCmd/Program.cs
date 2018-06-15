using ReverseMarkdown;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevMarkdownCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: need args. Pass one directory to convert all .html into .md; pass two files to convert first.html into second.md");
                Environment.Exit(1);
            }
            var config = new Config(Config.UnknownTagsOption.PassThrough, false, true);
            var conv = new Converter(config);

            Func<string, string> htmlToTxt = html => conv.Convert(html);

            var fa = File.GetAttributes(args[0]);
            if ((fa & FileAttributes.Directory) == FileAttributes.Directory)
            {
                foreach (var infile in Directory.GetFiles(args[0], "*.html"))
                {
                    Console.Out.Write($"{infile}\n");
                    Console.Out.Flush();
                    var outfile = Path.ChangeExtension(infile, ".md");
                    conv.CurrentContext = infile;
                    var result = htmlToTxt(File.ReadAllText(infile));
                    File.WriteAllText(outfile, result);
                }

                Console.WriteLine();
                Console.WriteLine();
                foreach (var kvp in conv.DefaultedTagCounts.OrderBy(k => k.Value))
                    if (kvp.Value > 1)
                        Console.WriteLine($"{kvp.Value}\t{kvp.Key}\t{conv.DefaultedTagContext(kvp.Key)}");
                return;
            }
            if (args.Length != 2)
                throw new Exception("ERROR: if first arg is file, second arg should be outfile");
            {
                var result = htmlToTxt(File.ReadAllText(args[0]));
                File.WriteAllText(args[1], result);
            }
        }
    }
}
