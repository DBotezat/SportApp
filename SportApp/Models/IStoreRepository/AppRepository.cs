using SportApp.Models.Entities;

namespace SportApp.Models.IStoreRepository
{
    public class AppRepository : IStoreRepository 
    {
        private MyContext context;

        public AppRepository(MyContext ctx)
        {
            context = ctx;
        }

       
        public IQueryable<PersonalAccount> PersonalAccounts => context.PersonalAccounts;
    }
}
