namespace Webapp.Shared.Entities
{
    public class SavingEntity
    {
        public int Id { get; set; }
        public int SavingTypeId { get; set; }
        public required string Name { get; set; }
        public decimal Amount { get; set; }
        public required DateTime AddingDate { get; set; }

    }
}