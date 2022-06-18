using System;

namespace DependencyInjection.Repo
{
    public class TestRepo : ITestRepo
    {
        private readonly Guid _guid;

        
        public TestRepo()
        {
            _guid = Guid.NewGuid();
        }

        public Guid GetGuid()
        {
            return _guid;
        }
    }
}