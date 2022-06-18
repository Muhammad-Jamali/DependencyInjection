using DependencyInjection.Controller;
using DependencyInjection.DiWorking;
using DependencyInjection.Repo;
using DependencyInjection.Service;

namespace DependencyInjection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = new ServiceContainer();

            services.RegisterSingleton<IUserRepo, UserRepo>();
            services.RegisterSingleton<IUserService, UserService>();
            services.RegisterTransient<ITestRepo, TestRepo>();
            services.RegisterSingleton(typeof(UserController));

            var container = services.GetDiContainer();

            container.GetService<UserController>().RunMe();
        }
    }
}