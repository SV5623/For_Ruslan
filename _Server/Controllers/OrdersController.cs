using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuslanPR_Library.Models;
using System.Linq;
using System.Threading.Tasks;
using RuslanPR_Server.Data;

namespace RuslanPR_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = _context.Orders.ToList();
            return Ok(orders);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                return Ok(order);
            }
            return BadRequest(ModelState);
        }
    }
}