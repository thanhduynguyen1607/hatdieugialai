using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HatDieuGiaLai.Shared;

namespace HatDieuGiaLai.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DieusController : ControllerBase
    {
        private readonly HatDieuGiaLaiDbContext db;
        public DieusController(HatDieuGiaLaiDbContext db)
        {
            this.db = db;
        }

        [HttpGet("/dieus")]
        public IQueryable<Dieu> GetDieus()
        => this.db.Dieus;

        [HttpPost("/dieus")]
        public IActionResult InsertDieu([FromBody] Dieu dieu)
        {
            db.Dieus.Add(dieu);
            db.SaveChanges();
            return Created($"dieus/{dieu.Id}", dieu);
        }
    }
}
