namespace Pratik43.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = default!;
        public string Email { get; set; } = default!;
        public List<Post>? Posts { get; set; }
    }
}
