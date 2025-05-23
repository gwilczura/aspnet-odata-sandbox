using Microsoft.AspNetCore.Mvc;

namespace Wilczura.Odata.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    public string Get()
    {
        return "OK";
    }
}
