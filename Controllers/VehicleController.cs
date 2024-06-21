using CarExpertise.Data;
using CarExpertise.Models; // VehicleModel sınıfını doğru isim alanından kullanmak için ekledik
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CarExpertise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public VehicleController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("list")]
        public IActionResult GetModelList()
        {
            var modelList = _db.VehicleModelss.ToList();
            return Ok(modelList);
        }


        [HttpPost("addmodel")]
        public IActionResult AddModel(IEnumerable<VehicleModels> models)
        {
            if (models == null || !models.Any())
            {
                return BadRequest("Model list is empty.");
            }

            foreach (var model in models)
            {
                _db.VehicleModelss.Add(model);
            }

            _db.SaveChanges();

            return Ok("Models added successfully.");
        }
    }
}
