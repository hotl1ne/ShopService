using Microsoft.AspNetCore.Mvc;
using ShopService.Application.Services;

namespace ShopService.API.Controllers
{
    [ApiController]
    [Route("/order")]
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("recent-buyers/{days}")]
        public async Task<ActionResult> GetRecentBuyers(int days)
        {
            var recentBuyers = await _orderService.GetRecentBuyers(days);

            if(recentBuyers == null || !recentBuyers.Any())
            {
                return NotFound("Recent buyers was not found on this days");
            }

            return Ok(recentBuyers);
        }

        [HttpGet("customer-cart/{id}")]
        public async Task<ActionResult> GetCustomerCart(Guid id)
        {
            var customerCart = await _orderService.GetCustomerCategories(id);

            if(customerCart == null || !customerCart.Any())
            {
                return NotFound("Customer has not ordered anything yet");
            }

            return Ok(customerCart);
        }
    }
}
