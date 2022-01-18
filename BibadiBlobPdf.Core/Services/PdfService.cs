using BibadiBlobPdf.Core.Converters.HtmlConverter;
using BibadiBlobPdf.Models;

namespace BibadiBlobPdf.Core.Services
{
    public class PdfService : IPdfService
    {
        IHtmlConverter _htmlConverter;

        public PdfService(IHtmlConverter htmlConverter) => _htmlConverter = htmlConverter;

        public Task<Pdf> ConvertHtmlToPdf(Html html) => Task.Run(() => _htmlConverter.Convert(html));

        public Task<Pdf> ConvertImgToPdf(Img img)
        {
            return Task.Run(() =>
            {
                return new Pdf
                {
                    Content = Array.Empty<byte>()
                };
            });
        }

        public Task<Pdf> CombinePdfs(PdfList pdfs)
        {
            return Task.Run(() =>
            {
                return new Pdf
                {
                    Content = Array.Empty<byte>()
                };
            });
        }
    }
}
