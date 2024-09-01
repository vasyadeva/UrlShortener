using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UrlShortener.Configurations.ShortenerUrl;
using UrlShortener.Data;
using UrlShortener.Data.Entities;
using UrlShortener.Interfaces;
using UrlShortener.Models;

namespace UrlShortener.Services
{
    public class UrlService : IUrlService
    {
        private const string ShortUrlBase = "https://localhost:7087";
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UrlService(ApplicationDbContext _context, IHttpContextAccessor httpContextAccessor)
        {
            this._context = _context;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<string> CreateShortUrl(string longUrl, string UserId)
        {
            if (!Uri.TryCreate(longUrl, UriKind.Absolute, out _))
            {
                return "The specified URL is invalid.";
            }
            var IsExistingUrl = _context.Urls.FirstOrDefault(s => s.LongUrl == longUrl);
            if (IsExistingUrl != null)
            {
                return "This URL already exists.";
            }
            var code = await GenerateUniqueCode();

            var urlModel = new Url
            {
                LongUrl = longUrl,
                ShortUrl = $"{ShortUrlBase}/{code}",
                Code = code,
                CreatedAt = DateTime.Now,
                UserId = UserId 
            };

            _context.Add(urlModel);
            _context.SaveChanges();
            return "";
        }

        private readonly Random _random = new();

        public async Task<string> GenerateUniqueCode()
        {
                var codeChars = new char[ShortLinkSettings.Length];
            int maxValue = ShortLinkSettings.Alphabet.Length;

            while (true)
            {
                for (var i = 0; i < ShortLinkSettings.Length; i++)
                {
                    var randomIndex = _random.Next(maxValue);

                    codeChars[i] = ShortLinkSettings.Alphabet[randomIndex];
                }
                var code = new string(codeChars);

                if (_context.Urls.FirstOrDefault(s => s.Code == code)==null)
                {
                    return code;
                }

            }
        }

        public Task<List<UrlModel>> GetAllUrls()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool IsAdmin = _httpContextAccessor.HttpContext.User.IsInRole("Administrator");
            var urlsModel = _context.Urls
           .Select(s => new UrlModel
           {
               Id = s.Id,
               LongUrl = s.LongUrl,
               ShortUrl = s.ShortUrl,
               IsAuthor = s.UserId == userId,
               IsAdmin = IsAdmin,
               isAuthorized = userId != null
           })
           .ToListAsync();

            return urlsModel;
        }

        public Task<UrlInfoModel> GetUrlById(int Id)
        {
            var url = _context.Urls.Where(s => s.Id == Id)
                .Select(s => new UrlInfoModel
                {
                    Id = s.Id,
                    LongUrl = s.LongUrl,
                    ShortUrl = s.ShortUrl,
                    CreatedAt = s.CreatedAt,
                    CreatedBy = s.User.UserName
                })
                .FirstOrDefaultAsync();
            return url;
        }


        public async Task<Boolean> DeleteUrlById(int Id)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool IsAdmin = _httpContextAccessor.HttpContext.User.IsInRole("Administrator");
            var url = _context.Urls.FirstOrDefault(s => s.Id == Id);
            if (url == null)
            {
                return false;
            }
            if (IsAdmin)
            {
                return await Dlt();
            }
            if (url.UserId != userId)
            {
                return false;
            }
            return await Dlt();
            async Task<Boolean> Dlt()
            {
                _context.Urls.Remove(url);
                await _context.SaveChangesAsync();
                return true;
            }
            
        }
    }
}
