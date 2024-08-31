
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UrlShortener.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                new IdentityUser
                {
                    Id = "ccf9bfb8-47d6-41bf-9c5d-502",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    NormalizedUserName = "ADMIN",
                    UserName = "admin",

                    PasswordHash = hasher.HashPassword(null, "Hello1234-"),
                    EmailConfirmed = true

                },
                new IdentityUser
                {
                    Id = "37bb0930-ee5b-483a-88a9-9fc2dab9a087",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER",
                    UserName = "user",

                    PasswordHash = hasher.HashPassword(null, "Hello1234-"),
                    EmailConfirmed = true

                },
                new IdentityUser
                {
                    Id = "37bb0930-ee5b-483a-88a9-9fc2dab9a903",
                    Email = "user2@localhost.com",
                    NormalizedEmail = "USER2@LOCALHOST.COM",
                    NormalizedUserName = "USER2",
                    UserName = "user2",

                    PasswordHash = hasher.HashPassword(null, "Hello1234-"),
                    EmailConfirmed = true

                }

                );
        }
    }
}