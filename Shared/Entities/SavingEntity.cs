using System.ComponentModel.DataAnnotations.Schema;

namespace Webapp.Shared.Entities
{

    public enum SavingCategory
    {
        Zakupy,
        Kosmetyki,
        Inne
    }
    public class SavingEntity
    {
        public int Id { get; set; }
        public SavingCategory Category { get; set; }
        public required string Name { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Amount { get; set; }
        public required DateTime Date { get; set; }


    }
}