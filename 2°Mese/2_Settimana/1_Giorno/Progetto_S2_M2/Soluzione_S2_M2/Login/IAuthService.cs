namespace Soluzione_S2_M2.Login
{
    public interface IAuthService
    {
        public User Login(string username, string password);
    }
}
