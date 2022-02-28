using SportApp.Models.Entities;

namespace SportApp.Models.IStoreRepository
{
    public interface IStoreRepository
    {
        IQueryable<PersonalAccount> PersonalAccounts { get; }
    }
}
