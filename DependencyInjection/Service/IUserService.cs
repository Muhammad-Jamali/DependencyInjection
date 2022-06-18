using DependencyInjection.Model;

namespace DependencyInjection.Service
{
    public interface IUserService
    {
        User AddUser(User model);
        User GetUser(int id);
    }
}