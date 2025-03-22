namespace PratikSurvivor.Dtos
{
    public class CreateCompetitorDto
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int CategoryId { get; set; }
    }
}
