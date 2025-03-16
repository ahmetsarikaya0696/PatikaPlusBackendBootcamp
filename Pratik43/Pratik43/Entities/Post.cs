namespace Pratik43.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Content { get; set; } = default!;
        public int UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
