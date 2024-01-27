using API.Domain;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class ShipController : ControllerBase
    {
        private readonly ILogger<ShipController> _logger;
        private readonly IShipRepository _repository;

        public ShipController(ILogger<ShipController> logger, IShipRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost]
        [Route("api/v1/ships")]
        public ActionResult Create([FromBody] Ship request)
        {
            return Ok(_repository.CreateShipAsync(request));
        }

        [HttpDelete]
        [Route("api/v1/ships/{id}")]
        public ActionResult Delete(Guid id)
        {
            return Ok(_repository.DeleteShipAsync(id));
        }

        [HttpGet]
        [Route("api/v1/ships/{id}")]
        public ActionResult GetByIdAsync(Guid id)
        {
            return Ok(_repository.GetShipByIdAsync(id));
        }

        [HttpPut]
        [Route("api/v1/ships")]
        public ActionResult UpdateAsync([FromBody] Ship request)
        {
            _repository.UpdateShipAsync(request);

            return NoContent();
        }
    }
}
