using Microsoft.AspNetCore.Mvc;

namespace ApiYoutube.Controllers
{
    [ApiController]

   
        public class PostsController : ControllerBase
        {

        [HttpGet]   
              public ActionResult GetAll ()
        {
            return Ok();
        }

           
        }
   
}
