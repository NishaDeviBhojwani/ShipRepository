using API.Domain;

namespace API.Repository
{
    public interface IShipRepository
    {
        Task CreateShipAsync(Ship ship);
        Task DeleteShipAsync(Guid id);
        Task<Ship> GetShipByIdAsync(Guid id);
        Task<List<Ship>> GetAllAsync();
        Task UpdateShipAsync(Ship ship);
    }
}
