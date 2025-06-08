using System.Drawing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    // default controller for "/" route
    [Route("")]
    [ApiController]
    public class Home : ControllerBase
    {
        public IActionResult Get()
        { 
            return Ok( new
            {
                scheme = Request.Scheme,
                host = Request.Host.Host,
                port = Request.Host.Port
            });
        }
    }
}
