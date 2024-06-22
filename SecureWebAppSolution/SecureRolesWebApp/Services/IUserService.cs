using SecureRolesWebApp.Entities;
using SecureRolesWebApp.Models;

namespace SecureRolesWebApp.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);

    }
}
