using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webapp.Shared.Entities
{

    public enum SavingCategory
    {
        Food, Transportation, Entertainment, Clothing, Media,
        Health,  Other
    }
    public class SavingEntity
    {
        public int Id { get; set; }
        [Required]
        public SavingCategory Category { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; } = DateTime.Now;


    }
}