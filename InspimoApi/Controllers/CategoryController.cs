using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InspimoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
         {
            return Ok();
         }

        [HttpPost]
        public IActionResult AddCategory()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCategory()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult PutCategory()
        {
            return Ok();
        }
    }
}
