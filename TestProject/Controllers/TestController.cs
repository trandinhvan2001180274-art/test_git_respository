using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]   
        public IActionResult GetAll()
        {
            //test 1
            string[] listName = ["Cong ty A", "Cong Ty B"];
            return Ok(listName);
        }
    }
}
