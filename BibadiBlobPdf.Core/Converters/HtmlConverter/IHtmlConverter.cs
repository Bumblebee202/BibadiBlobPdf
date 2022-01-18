using BibadiBlobPdf.Models;

namespace BibadiBlobPdf.Core.Converters.HtmlConverter
{
    public interface IHtmlConverter
    {
        Task<Pdf> Convert(Html html);
    }
}
