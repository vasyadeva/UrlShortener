namespace UrlShortener.Models
{
    public class UrlModel
    {
        public int Id { get; set; }
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }

        public Boolean IsAuthor { get; set;}
        public Boolean IsAdmin { get; set;}

        public Boolean isAuthorized { get; set;}
    }
}
