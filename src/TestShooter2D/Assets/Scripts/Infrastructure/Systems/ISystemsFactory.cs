using System;
using Entitas;

namespace Infrastructure.Systems
{
    public interface ISystemsFactory
    {
        T Create<T>() where T : ISystem;
        T Create<T>(params Object[] args) where T : ISystem;
    }
}