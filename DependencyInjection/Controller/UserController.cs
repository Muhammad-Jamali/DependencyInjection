using System;
using DependencyInjection.Model;
using DependencyInjection.Repo;
using DependencyInjection.Service;

namespace DependencyInjection.Controller
{
    public class UserController
    {
        private readonly IUserService _userService;
        private readonly ITestRepo _testRepo;
        private readonly ITestRepo _testRepo2;

        public UserController(IUserService userService, ITestRepo testRepo, ITestRepo testRepo2)
        {
            _userService = userService;
            _testRepo = testRepo;
            _testRepo2 = testRepo2;
        }

        public void RunMe()
        {

           Console.WriteLine(_testRepo.GetGuid());
           Console.WriteLine(_testRepo2.GetGuid());
           
        }
    }
}