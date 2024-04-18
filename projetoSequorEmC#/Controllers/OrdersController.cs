using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using projetoSequorEmC_.Services;
using System.Text.Json.Nodes;

namespace projetoSequorEmC_.Models
{
    [ApiController]
    [Route("api/orders")] 
    public class OrdersController : ControllerBase
    {

        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
            try
            {
                var orders = _orderService.GetAllOrdersAsJson();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error" + ex.Message);
            }
            
        }

        [HttpGet("GetProduction")]
        public IActionResult GetProduction([FromQuery] string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return BadRequest("Requer um email.");
            }

            try
            {
                var productions = _orderService.GetProductionsByEmail(email);
                if (productions == null || !productions.Any())
                    return Ok(new List<object>());
                return Ok(productions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
            

        }

        [HttpPost("SetProduction")]
        public IActionResult SetProduction([FromBody] Production production)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _orderService.ValidateProdution(production);

            if (result.IsSuccess)
            {
                return Ok(new { message = "Produção registrada.", status = 200, type = "S" });
            }
            else
            {
                return StatusCode(500, new { message = result.ErrorMessage, status = 201, Type = "E" });
            }

        }

    }
}
