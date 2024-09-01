using UrlShortener.Data.Entities;
using UrlShortener.Models;

namespace UrlShortener.Interfaces
{
    public interface IUrlService
    {
        Task<string> CreateShortUrl(string LongUrl, string UserId);
        Task<List<UrlModel>> GetAllUrls();
        Task<UrlInfoModel> GetUrlById(int Id);
        Task<Boolean> DeleteUrlById(int Id);
    }
}
