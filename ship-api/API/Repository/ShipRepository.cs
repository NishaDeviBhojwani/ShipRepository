using API.Database;
using API.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API.Repository
{
    public class ShipRepository : IShipRepository
    {
        private readonly DatabaseContext _databaseContext;

        public ShipRepository(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public async Task CreateShipAsync(Ship ship)
        {
            await _databaseContext.AddAsync(ship);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task DeleteShipAsync(Guid id)
        {
            var ship = await _databaseContext.Ships.FindAsync(id);

            if (ship is null)
                throw new KeyNotFoundException();

            _databaseContext.Ships.Remove(ship);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task<List<Ship>> GetAllAsync()
        {
            return await _databaseContext.Ships.ToListAsync();
        }

        public async Task<Ship> GetShipByIdAsync(Guid id)
        {
            var ship = await _databaseContext.Ships.FindAsync(id);
            if (ship is null)
                throw new KeyNotFoundException();
            return ship;
        }

        public async Task UpdateShipAsync(Ship ship)
        {
            _databaseContext.Update(ship);
            await _databaseContext.SaveChangesAsync();
        }
    }

}
