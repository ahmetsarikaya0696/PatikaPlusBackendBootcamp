using Pratik46.Models;

namespace Pratik46.Services
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
