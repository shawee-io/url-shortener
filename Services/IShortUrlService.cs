using UrlShortener.Models;

namespace UrlShortener.Services
{
    public interface IUrlShortenerService
    {
        Url Get(string path);

        string Save(string originalUrl);
    }
}
