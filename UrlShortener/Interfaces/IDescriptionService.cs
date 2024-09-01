using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Interfaces
{
    public interface IDescriptionService
    {
        Task<string> GetDescription();
        Task<bool> ModifyDescription(string description);
    }
}
