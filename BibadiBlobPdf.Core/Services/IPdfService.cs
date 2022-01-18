using BibadiBlobPdf.Models;

namespace BibadiBlobPdf.Core.Services
{
    public interface IPdfService
    {
        Task<Pdf> ConvertImgToPdf(Img img);
        Task<Pdf> ConvertHtmlToPdf(Html html);
        Task<Pdf> CombinePdfs(PdfList pdfs);
    }
}
