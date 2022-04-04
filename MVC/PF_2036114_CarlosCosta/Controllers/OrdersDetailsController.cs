using Microsoft.AspNetCore.Mvc;
using Teste.Models;
using Teste.Services;

namespace Teste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersDetailsController : ControllerBase
    {
        private readonly IOrderDetailService service; 

        public OrdersDetailsController(IOrderDetailService _service)  
        {
            this.service = _service;
        }

        // GET: api/<BooksController>
        [HttpGet("orders")]
        public IEnumerable<OrderDetail> Get()
        {
            return service.GetAll();
        }

        // GET: api/<BooksController>
        [HttpGet("orders/{id}")]
        public IActionResult Get(int orderId)
        {
            OrderDetail orderDetails = service.GetById(orderId);
            if (orderDetails is null)
            {
                return NotFound("Order not found!");
            }
            else
            {
                return Ok(orderDetails);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderDetail newOrder) 
        {
            if (newOrder is not null)
            {
                OrderDetail orderDetail = service.Create(newOrder);
                return CreatedAtRoute("Get", new { orderId = newOrder.orderId }, newOrder); 
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("orders/{id:int}")]
        public IActionResult Delete(int orderId) 
        {
            OrderDetail deleteOrder = service.GetById(orderId);
            if (deleteOrder is not null)
            {
                service.DeleteById(deleteOrder.orderId);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("orders/{id:int}", Name = "Update Order")]
        public IActionResult UpdateOder(int oderId,  [FromBody] OrderDetail updateOrder) 
        {
            OrderDetail orderToUpdate = service.GetById(oderId);
            if (orderToUpdate is not null || updateOrder is not null)
            {
                service.Update(updateOrder.orderId, updateOrder);
                return Ok(orderToUpdate);
            }
            else
            {
                return BadRequest();
            }
        }

        // GET By Author
        [HttpGet("orders/{orderId}/products", Name = "Get All Products")]
        public IEnumerable<Product> GetByAuthor(int orderId) 
        {
            return service.GetProducts(orderId);
        }

        [HttpPatch("orders/{orderId:int}/amount", Name = "Update Order Amout")]
        public IActionResult UpdateAmount(int orderId, double amout) // 4.d.viii
        {
            OrderDetail updateAmount = service.GetById(orderId);
            if (updateAmount is not null)
            {
                service.UpdateAmout(orderId, amout);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}