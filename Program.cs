using System;
using System.Threading.Tasks;

namespace guidgen2
{
    class Program
    {
        [STAThread]
        static async Task Main(string[] args)
        {
            var guid = Guid.NewGuid();
            var guidString = guid.ToString();
            await TextCopy.ClipboardService.SetTextAsync(guidString);
            await Console.Out.WriteLineAsync(guidString);
        }
    }
}
