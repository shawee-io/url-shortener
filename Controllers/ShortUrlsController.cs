using Microsoft.AspNetCore.Mvc;
using UrlShortener.Services;

namespace UrlShortener.Controllers
{
    [Route("[controller]")]
    public class ShortUrlsController : Controller
    {
        private readonly IUrlShortenerService _service;

        public ShortUrlsController(IUrlShortenerService service)
        {
            _service = service;
        }
      
        [HttpPost]
        public IActionResult Post([FromBody] URLParameter parameter)
        {
            var shortURL = _service.Save(parameter.Url);

            return Json(shortURL);
        }

        [HttpGet]
        [Route("{shortUrl}")]
        public IActionResult Get(string shortUrl)
        {
            var url = _service.Get(shortUrl);

            if (url != null)
            {
                return Redirect(url.OriginalUrl);
            }

            return NotFound();
        }

        public class URLParameter
        {
            public string Url { get; set; }
        }
    }
}
