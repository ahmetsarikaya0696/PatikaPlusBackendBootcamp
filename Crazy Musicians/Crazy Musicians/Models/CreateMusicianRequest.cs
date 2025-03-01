namespace Crazy_Musicians.Models
{
    public class CreateMusicianRequest
    {
        public string FullName { get; set; } = default!;
        public string Job { get; set; } = default!;
        public string FunFeature { get; set; } = default!;
    }
}
