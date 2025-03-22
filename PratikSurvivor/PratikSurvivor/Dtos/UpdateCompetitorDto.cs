namespace PratikSurvivor.Dtos
{
    public class UpdateCompetitorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int CategoryId { get; set; }
    }
}
