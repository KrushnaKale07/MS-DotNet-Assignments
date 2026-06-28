using WebApplDay9.Models;

namespace WebApplDay9.DAO
{
    public interface IUserDAO
    {
        void Register(User user);
        User? ValidateUser (string userName, string password);
    }
}
