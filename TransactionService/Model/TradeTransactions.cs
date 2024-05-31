using System.ComponentModel.DataAnnotations;

namespace TransactionService.Model
{
    public class TradeTransactions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TradeType {  get; set; }
    }
}
