using System;
using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;

// ReSharper disable once CheckNamespace
namespace Common.Entity.ToStrings
{
  public sealed partial class GameEntity : INamedEntity
  {
    private EntityPrinter _printer;

    public override string ToString()
    {
      if (_printer == null)
        _printer = new EntityPrinter(this);

      _printer.InvalidateCache();

      return _printer.BuildToString();
    }

    public string EntityName(IComponent[] components)
    {
      try
      {
        if (components.Length == 1)
          return components[0].GetType().Name;

        foreach (IComponent component in components)
        {
          switch (component.GetType().Name)
          {
            // case nameof(Hero):
            //   return PrintHero();
            //
            // case nameof(Enemy):
            //   return PrintEnemy();
          }
        }
      }
      catch (Exception exception)
      {
        Debug.LogError(exception.Message);
      }

      return components.First().GetType().Name;
    }

    public string BaseToString() => base.ToString();
    public void Retain(object owner)
    {
      throw new NotImplementedException();
    }

    public void Release(object owner)
    {
      throw new NotImplementedException();
    }

    public int retainCount { get; }

    public void Initialize(int creationIndex, int totalComponents, Stack<IComponent>[] componentPools, ContextInfo contextInfo = null,
      IAERC aerc = null)
    {
      throw new NotImplementedException();
    }

    public void Reactivate(int creationIndex)
    {
      throw new NotImplementedException();
    }

    public void AddComponent(int index, IComponent component)
    {
      throw new NotImplementedException();
    }

    public void RemoveComponent(int index)
    {
      throw new NotImplementedException();
    }

    public void ReplaceComponent(int index, IComponent component)
    {
      throw new NotImplementedException();
    }

    public IComponent GetComponent(int index)
    {
      throw new NotImplementedException();
    }

    public IComponent[] GetComponents()
    {
      throw new NotImplementedException();
    }

    public int[] GetComponentIndices()
    {
      throw new NotImplementedException();
    }

    public bool HasComponent(int index)
    {
      throw new NotImplementedException();
    }

    public bool HasComponents(int[] indices)
    {
      throw new NotImplementedException();
    }

    public bool HasAnyComponent(int[] indices)
    {
      throw new NotImplementedException();
    }

    public void RemoveAllComponents()
    {
      throw new NotImplementedException();
    }

    public Stack<IComponent> GetComponentPool(int index)
    {
      throw new NotImplementedException();
    }

    public IComponent CreateComponent(int index, Type type)
    {
      throw new NotImplementedException();
    }

    public T CreateComponent<T>(int index) where T : new()
    {
      throw new NotImplementedException();
    }

    public void Destroy()
    {
      throw new NotImplementedException();
    }

    public void InternalDestroy()
    {
      throw new NotImplementedException();
    }

    public void RemoveAllOnEntityReleasedHandlers()
    {
      throw new NotImplementedException();
    }

    public int totalComponents { get; }
    public int creationIndex { get; }
    public bool isEnabled { get; }
    public Stack<IComponent>[] componentPools { get; }
    public ContextInfo contextInfo { get; }
    public IAERC aerc { get; }
    public event EntityComponentChanged OnComponentAdded;
    public event EntityComponentChanged OnComponentRemoved;
    public event EntityComponentReplaced OnComponentReplaced;
    public event EntityEvent OnEntityReleased;
    public event EntityEvent OnDestroyEntity;
  }
}

