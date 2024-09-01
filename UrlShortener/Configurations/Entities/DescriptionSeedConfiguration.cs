using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrlShortener.Data.Entities;

namespace UrlShortener.Configurations.Entities
{
    public class DescriptionSeedConfiguration : IEntityTypeConfiguration<Description>
    {
        public void Configure(EntityTypeBuilder<Description> builder)
        {
            builder.HasData(
                new Description
                {
                    Id = 1,
                   Text = "URL shortener service is designed to simplify and enhance the management of long web addresses. Whether you’re sharing links on social media, in emails, or anywhere else, the tool helps by converting lengthy URLs into shorter, more manageable links.\r\n\r\nHow It Works:\r\n\r\n    Creating Short URLs:\r\n        When you provide a long URL, the service generates a unique short link for you. This short link redirects users to the original long URL, but in a much more convenient format.\r\n\r\n    Generating Unique Short Codes:\r\n        Each short link is created using a combination of letters and numbers, ensuring that every link is unique. This short code is what users will see and click on, making it easy to remember and share.\r\n\r\n    Managing Your Links:\r\n        You can view all the short URLs you’ve created, along with details like the original long URL and the date it was created. If you have administrator privileges, you can also manage and delete URLs.\r\n\r\n    Permissions and Security:\r\n        Only authorized users, like administrators or the original creators, can delete or modify URLs. This ensures that your links are secure and only accessible by those who have the right permissions."
                });
        }
    }
}
