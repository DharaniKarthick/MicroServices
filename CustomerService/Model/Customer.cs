using System.ComponentModel.DataAnnotations;

namespace CustomerService.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? Address { get; set; }
    }

}
