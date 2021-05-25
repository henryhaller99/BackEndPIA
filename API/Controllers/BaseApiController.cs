using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BaseApiController : ControllerBase
    {
        // este controlador solo se utilizará ya que como lo dice su nombre
        // esta clase se heredará  [ApiController] [Route("api/[controller]")] en todo los controladores por lo tanto 
        // es buena practica
    }
}