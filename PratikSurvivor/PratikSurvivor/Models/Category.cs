namespace PratikSurvivor.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<Competitor>? Competitors { get; set; }
    }
}
