using TransactionService.DatabaseContext;
using TransactionService.Model;

namespace TransactionService.Repository
{
    public class TransactionRepository:ITransactionRepository
    {
        private readonly TransactionDBContext _context;

        public TransactionRepository(TransactionDBContext context)
        {
            _context = context;
        }

        public TradeTransactions GetTradeTransactionById(int id)
        {
            return _context.TradeTransactions.Find(id);
        }

        public List<TradeStatus> GetAllStatusById(int id)
        {
            return _context.TransactionStatuses.Where(x=>x.TradeId == id).ToList();
        }
    }
}
