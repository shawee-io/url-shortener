using System.Linq;
using UrlShortener.Data;
using UrlShortener.Helpers;
using UrlShortener.Models;

namespace UrlShortener.Services
{
    public class UrlShortenerService : IUrlShortenerService
    {
        private readonly UrlShortenerContext _context;

        public UrlShortenerService(UrlShortenerContext context)
        {
            _context = context;
        }

        public Url Get(string shortUrl)
        {
            return _context.Urls.Where(x => x.Id == ShortnerUrlHelper.Decode(shortUrl)).FirstOrDefault();
        }

        public string Save(string originalUrl)
        {
            Url url = new Url()
            {
                OriginalUrl = originalUrl
            };

            _context.Urls.Add(url);
            _context.SaveChanges();

            return ShortnerUrlHelper.Encode(url.Id);
        }
    }
}
