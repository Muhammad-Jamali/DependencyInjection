using System.Collections.Generic;
using DependencyInjection.Model;

namespace DependencyInjection.Repo
{
    public class UserRepo : IUserRepo
    {
        private static readonly Dictionary<int, User> _users = new();
        public User AddUser(User model)
        {
            _users.Add(model.Id, model);
            return model;
        }

        public User GetUser(int id)
        {
            return !_users.ContainsKey(id) ? null : _users[id];
        }
    }
}