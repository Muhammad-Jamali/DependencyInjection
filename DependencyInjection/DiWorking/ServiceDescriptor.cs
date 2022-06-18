using System;

namespace DependencyInjection.DiWorking
{
    public class ServiceDescriptor
    {
        public Type TypeService { get; set; }
        public Type TypeImplementation { get; set; }
        public object Implementation { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}