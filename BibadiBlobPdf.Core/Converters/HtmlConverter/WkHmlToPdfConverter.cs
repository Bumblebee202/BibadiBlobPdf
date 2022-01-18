using System.Diagnostics;

namespace BibadiBlobPdf.Core.Converters.HtmlConverter
{
    public class WkHmlToPdfConverter : HtmlConverterBase
    {
        protected override byte[] StartProcess(string filePath)
        {
            var process = new Process();

            var startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = "wkhtmlPath";
            startInfo.Arguments = $"--enable-local-file-access {string.Join(' ', Arguments)}";

            startInfo.WorkingDirectory = AppContext.BaseDirectory;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            process.Start();

            return Array.Empty<byte>();
        }
    }
}
