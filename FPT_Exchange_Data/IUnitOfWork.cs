using FPT_Exchange_Data.Repositories.Implementations;
using Microsoft.EntityFrameworkCore.Storage;

namespace FPT_Exchange_Data
{
    public interface IUnitOfWork
    {
        public IUserRepository User { get; }


        Task<int> SaveChanges();
        IDbContextTransaction Transaction();
    }
}
