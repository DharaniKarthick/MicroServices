using System.ComponentModel.DataAnnotations;

namespace SupplierServices.Model
{
    public class Supplier
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
