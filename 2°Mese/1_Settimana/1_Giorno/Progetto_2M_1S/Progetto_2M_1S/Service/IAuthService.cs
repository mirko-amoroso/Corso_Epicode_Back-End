using Progetto_2M_1S.Models;

namespace Progetto_2M_1S.Service
{
    public interface IAuthService
    {
        User Login(string username, string password);
    }
}
