using System;
using Entitas;
using Zenject;

namespace Infrastructure.Systems
{
    public class SystemsFactory : ISystemsFactory
    {
        private readonly DiContainer _diContainer;

        public SystemsFactory(DiContainer diContainer)
        {
            _diContainer = diContainer;
        }

        public T Create<T>() where T : ISystem => 
            _diContainer.Instantiate<T>();
        
        public T Create<T>(params Object[] args) where T : ISystem => 
            _diContainer.Instantiate<T>(args);
    }
}