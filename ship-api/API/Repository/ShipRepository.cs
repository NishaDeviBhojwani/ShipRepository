using API.Database;
using API.Domain;

namespace API.Repository
{
    public class ShipRepository : IShipRepository
    {
        private readonly List<Ship> _ships;
        private readonly DatabaseContext _databaseContext;
        public ShipRepository(DatabaseContext context)
        {
            _databaseContext = context;
            _ships = new List<Ship>
                {
                    new Ship
                    {
                        Id = Guid.NewGuid(),
                        Name ="Ship1",
                        Width = 123,
                        Length = 232,
                        Code = "111-xyz-123",
                        CreatedDateTime = DateTime.Now,
                        ModifiedDateTime = DateTime.Now,
                        IsDeleted = false
                    },
                    new Ship
                    {
                        Id = Guid.NewGuid(),
                        Name ="Ship2",
                        Width = 123,
                        Length = 232,
                        Code = "111-xyz-123",
                        CreatedDateTime = DateTime.Now,
                        ModifiedDateTime = DateTime.Now,
                        IsDeleted = false
                    },
                    new Ship
                    {
                        Id = Guid.NewGuid(),
                        Name ="Ship3",
                        Width = 123,
                        Length = 232,
                        Code = "111-xyz-123",
                        CreatedDateTime = DateTime.Now,
                        ModifiedDateTime = DateTime.Now,
                        IsDeleted = false
                    }
                };
            context.Ships.AddRange(_ships);
            context.SaveChanges();
        }

        public Task CreateShipAsync(Ship ship)
        {
            _databaseContext.Add(ship);
            _databaseContext.SaveChanges();
            return Task.CompletedTask;
        }

        public Task DeleteShipAsync(Guid id)
        {
            _ships.Where(note => note.Id != id).ToList();
            return Task.CompletedTask;
        }

        public Task<List<Ship>> GetShipByIdAsync(Guid id)
        {
            return Task.FromResult<List<Ship>>(_ships);
        }

        public Task UpdateShipAsync(Ship ship)
        {
            throw new NotImplementedException();
        }
    }

}
