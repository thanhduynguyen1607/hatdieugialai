using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HatDieuGiaLai.Shared;

namespace HatDieuGiaLai.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly HatDieuGiaLaiDbContext db;
        public OrdersController(HatDieuGiaLaiDbContext db)
        {
            this.db = db;
        }
        [HttpPost("/orders")]
        public IActionResult InsertOrder([FromBody] ShoppingBasket basket)
        {
            Order order = new Order();
            order.Customer = basket.Customer;
            order.Dieus = new List<Dieu>();
            foreach (int dieuId in basket.Orders)
            {
                var dieu = db.Dieus.Single(p => p.Id == dieuId);
            }
            db.Orders.Add(order);
            db.SaveChanges();
            return Created("/orders", order.Id);
        }
    }
}
