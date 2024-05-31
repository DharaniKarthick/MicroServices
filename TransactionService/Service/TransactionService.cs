using TransactionService.Model;
using TransactionService.Repository;

namespace TransactionService.Service
{
    public class TransactionsService:ITransactionService
    {
        private readonly ITransactionRepository _repository;

        public TransactionsService(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public TradeTransactions GetTradeTransactionById(int id)
        {
            return _repository.GetTradeTransactionById(id);
        }

        public List<TradeStatus> GetAllStatusById(int id)
        {
            return _repository.GetAllStatusById(id);
        }
    }
}
