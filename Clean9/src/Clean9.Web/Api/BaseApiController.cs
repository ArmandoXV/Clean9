using Microsoft.AspNetCore.Mvc;

namespace Clean9.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
