using API.Domain;

namespace API.Repository
{
    public interface IShipRepository
    {
        Task CreateShipAsync(Ship ship);
        Task DeleteShipAsync(Guid id);
        Task<List<Ship>> GetShipByIdAsync(Guid id);
        Task UpdateShipAsync(Ship ship);
    }
}
