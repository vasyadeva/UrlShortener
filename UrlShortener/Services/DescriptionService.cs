using Microsoft.AspNetCore.Mvc;
using UrlShortener.Data;
using UrlShortener.Data.Entities;
using UrlShortener.Interfaces;

namespace UrlShortener.Services
{
    public class DescriptionService : IDescriptionService
    {
        private readonly ApplicationDbContext context;
        public DescriptionService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task<string> GetDescription()
        {
            var record = context.Descriptions.FirstOrDefault();
            if (record == null)
            {
                return Task.FromResult("No description found");
            }
            return Task.FromResult(record.Text);

        }

        public async Task<bool> ModifyDescription(string description)
        {
            var record = context.Descriptions.FirstOrDefault();
            if (record == null)
            {
                return false;
            }
            else
            {
                record.Text = description;
            }
            await context.SaveChangesAsync();
            return true;

        }

    }
}
