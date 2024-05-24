using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class AccountService : BaseService<Account>, IAccountService
    {
        public AccountService(IAccountRepository accountRepository) : base(accountRepository)
        {
        }
    }
}