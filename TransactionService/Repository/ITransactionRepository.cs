using TransactionService.Model;

namespace TransactionService.Repository
{
    public interface ITransactionRepository
    {
        TradeTransactions GetTradeTransactionById(int id);
        List<TradeStatus> GetAllStatusById(int id);
    }
}
