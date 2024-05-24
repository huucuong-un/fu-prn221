using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class TransactionService : BaseService<Transaction>, ITransactionService
    {
        public TransactionService(ITransactionRepository transactionRepository) : base(transactionRepository)
        {
        }
    }
}