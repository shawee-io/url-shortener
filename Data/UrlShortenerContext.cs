using Microsoft.EntityFrameworkCore;
using UrlShortener.Models;

namespace UrlShortener.Data
{
    public class UrlShortenerContext : DbContext
    {
        public UrlShortenerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Url> Urls { get; set; }
    }
}
