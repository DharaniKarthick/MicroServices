using TransactionService.Model;

namespace TransactionService.Service
{
    public interface ITransactionService
    {
        TradeTransactions GetTradeTransactionById(int id);
        List<TradeStatus> GetAllStatusById(int id);
    }
}
