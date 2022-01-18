using BibadiBlobPdf.Models;

namespace BibadiBlobPdf.Core.Converters.HtmlConverter
{
    public abstract class HtmlConverterBase : IHtmlConverter
    {
        string TempFolderPath => "path";

        public IEnumerable<string> Arguments { get; set; }

        public async Task<Pdf> Convert(Html html)
        {
            if (!Directory.Exists(TempFolderPath))
            {
                Directory.CreateDirectory(TempFolderPath);
            }

            var fileName = Guid.NewGuid().ToString();
            var filePath = Path.Combine(TempFolderPath, fileName);

            try
            {
                await File.WriteAllBytesAsync(filePath, html.Content);

                var bytes = StartProcess(filePath);

                return new Pdf
                {
                    Content = bytes
                };
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                File.Delete(filePath);
            }
        }

        protected abstract byte[] StartProcess(string filePath);
    }
}
