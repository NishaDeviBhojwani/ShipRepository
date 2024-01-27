using API.Domain;
using API.Repository;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class ShipController : ControllerBase
    {
        private readonly IShipRepository _repository;
        private readonly IValidator<Ship> _validator;

        public ShipController(IShipRepository repository, IValidator<Ship> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        [HttpPost]
        [Route("api/v1/ships")]
        public async Task<ActionResult> Create([FromBody] Ship request)
        {
            _validator.ValidateAndThrow(request);

            await _repository.CreateShipAsync(request);

            return Ok();
        }

        [HttpDelete]
        [Route("api/v1/ships/{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException("Id");
            }

            await _repository.DeleteShipAsync(id);

            return Ok();
        }

        [HttpGet]
        [Route("api/v1/ships/{id}")]
        public async Task<ActionResult> GetByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException("Id");
            }

            return Ok(await _repository.GetShipByIdAsync(id));
        }

        [HttpGet]
        [Route("api/v1/ships")]
        public async Task<ActionResult> GetAllAsync()
        {
            return Ok(await _repository.GetAllAsync());
        }

        [HttpPut]
        [Route("api/v1/ships")]
        public async Task<ActionResult> UpdateAsync([FromBody] Ship request)
        {
            _validator.ValidateAndThrow(request);

            await _repository.UpdateShipAsync(request);

            return NoContent();
        }
    }
}
