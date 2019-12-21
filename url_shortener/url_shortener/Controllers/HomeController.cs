using System; 
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.AspNetCore.Mvc;
using url_shortener.App;

namespace url_shortener.Controllers
{
    public class URLReponse
    {
        public string url { get; set; }
        public string status { get; set; }
        public string token { get; set; }
    }
    
    public classj HomeController : Controller
    {
         // Index Route 
        [HttpGet, Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    
        [HttpPost, Route("/")]
        {
            public IActionResult PostURL([FromBody] string url)
            {
                throw new NotImplementedException();
            }
        }
        // Our Redirect Route
        [HttpGet, Route("/{token}")]
        public IActionResult NixRedirect([FromRoute] string token)
        {
            throw new NotImplementedException();
        }
    }
}