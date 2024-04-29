namespace Webapp.Shared.Entities
{
    public class SavingEntity
    {
        public int Id { get; set; }
        public int SavingTypeId { get; set; }
        public SavingType? SavingType { get; set; }
        public required string Name { get; set; }
        public decimal Amount { get; set; }
        public required DateTime Date { get; set; }


    }
}