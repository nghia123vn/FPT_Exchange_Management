using FPT_Exchange_Data.Entities;
using FPT_Exchange_Data.Repositories.Implementations;
using Microsoft.EntityFrameworkCore.Storage;

namespace FPT_Exchange_Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FptExchangeDbContext _context;

        private IUserRepository _user = null!;

        public UnitOfWork(FptExchangeDbContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get { return _user ??= new UserRepository(_context); }
        }


        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public IDbContextTransaction Transaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
