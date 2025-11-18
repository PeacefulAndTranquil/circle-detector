using System;
using System.Text.RegularExpressions;
using System.Threading;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Welcome to the Awesome Circle Identifier");
            Console.Write("Provide an input\n>");
            string inp = Console.ReadLine();
            Console.WriteLine("Processing...");
            Thread.Sleep(7);
            string outp = "Welcome to the Awesome Circle Identifier\nProvide an input\n>" + inp + "\nProcessing...";
            //regex heavily modified from https://stackoverflow.com/a/25301980
            outp = new Regex(@"(?!(?:o|O|i|j|:|\?|\!|;|\.|[\((o|O|i|\.)\)]|[[\(\)]|\n))(.)").Replace(outp, " ");
            outp = outp.Replace("i", "˙");
            outp = outp.Replace("j", "˙");
            outp = outp.Replace(";", "˙");
            outp = outp.Replace("?",".");
            outp = outp.Replace("!", ".");
            Console.Clear();
            Console.WriteLine(outp);
            Console.ReadKey();
        }
    }
}