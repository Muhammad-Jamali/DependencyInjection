using DependencyInjection.Model;
using DependencyInjection.Repo;

namespace DependencyInjection.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public User AddUser(User model)
            => _userRepo.AddUser(model);

        public User GetUser(int id)
            => _userRepo.GetUser(id);
    }
}