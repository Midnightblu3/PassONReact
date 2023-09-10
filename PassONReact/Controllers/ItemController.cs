using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PassONReact.Models;

namespace PassONReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly PassOndb1234Context _context;

        public ItemController(PassOndb1234Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetItems")]

        public IActionResult GetItems()
        {
            List<Item> itemList = _context.Items.ToList();
            return StatusCode(StatusCodes.Status200OK, itemList);
        }
    }
}
