using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjection.DiWorking
{
    public class DiContainer
    {
        private readonly Dictionary<Type, ServiceDescriptor> _serviceDict;

        public DiContainer(Dictionary<Type, ServiceDescriptor> serviceDict)
        {
            _serviceDict = serviceDict;
        }

        private object GetService(Type service)
        {
            if (!_serviceDict.ContainsKey(service))
                throw new Exception($"Service of type {service} not registered!");

            var serviceDescriptor = _serviceDict[service];

            //Transient
            if (serviceDescriptor.ServiceType == ServiceType.Transient)
                return  Activator.CreateInstance(serviceDescriptor.TypeImplementation);
            
            //Singleton
            var constructorInfo = serviceDescriptor.TypeImplementation.GetConstructors().First();
            var prams = constructorInfo.GetParameters().Select(x => GetService(x.ParameterType)).ToArray();

            return serviceDescriptor.Implementation ?? (serviceDescriptor.Implementation =
                Activator.CreateInstance(serviceDescriptor.TypeImplementation, prams));
        }
        public TService GetService<TService>()
        {
            return (TService) GetService(typeof(TService));
        }
    }
}