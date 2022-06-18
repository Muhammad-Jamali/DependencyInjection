using DependencyInjection.Model;

namespace DependencyInjection.Repo
{
    public interface IUserRepo
    {
        User AddUser(User model);
        User GetUser(int id);
    }
}