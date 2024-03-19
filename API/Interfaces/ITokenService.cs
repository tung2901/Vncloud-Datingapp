using API.Entities;

namespace API.Interfaces
{
    public interface TokenService
    {
        string createToken(AppUser user);
    }
}