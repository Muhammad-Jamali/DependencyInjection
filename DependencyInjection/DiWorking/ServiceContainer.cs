using System;
using System.Collections.Generic;

namespace DependencyInjection.DiWorking
{
    public class ServiceContainer
    {
        private readonly Dictionary<Type, ServiceDescriptor> _serviceDict = new();

        public void RegisterSingleton<T>(T obj)
        {
            _serviceDict.Add(typeof(T), new ServiceDescriptor
            {
                TypeService = typeof(T),
                TypeImplementation = typeof(T),
                ServiceType = ServiceType.Singleton
            });
        } 
        public void RegisterSingleton(Type type)
        {
           if(!type.IsClass) throw new Exception("Type should be class");
            _serviceDict.Add(type, new ServiceDescriptor
            {
                TypeService = type,
                TypeImplementation = type,
                ServiceType = ServiceType.Singleton
            });
        }

        public void RegisterSingleton<TService, TImpl>() where TImpl : TService
        {
            _serviceDict.Add(typeof(TService), new ServiceDescriptor
            {
                TypeService = typeof(TService),
                TypeImplementation = typeof(TImpl),
                ServiceType = ServiceType.Singleton
            });
        }


        public void RegisterTransient<T>(T obj)
        {
            _serviceDict.Add(typeof(T), new ServiceDescriptor
            {
                TypeService = typeof(T),
                TypeImplementation = typeof(T),
                ServiceType = ServiceType.Transient
            });
        }

        public void RegisterTransient<TService, TImpl>() where TImpl : TService
        {
            _serviceDict.Add(typeof(TService), new ServiceDescriptor
            {
                TypeService = typeof(TService),
                TypeImplementation = typeof(TImpl),
                ServiceType = ServiceType.Transient
            });
        }

        public DiContainer GetDiContainer()
        {
            return new DiContainer(_serviceDict);
        }
    }
}