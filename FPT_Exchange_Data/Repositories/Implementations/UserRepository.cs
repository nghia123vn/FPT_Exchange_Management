using FPT_Exchange_Data.Entities;

namespace FPT_Exchange_Data.Repositories.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(FptExchangeDbContext context) : base(context)
        {
        }
    }
}
