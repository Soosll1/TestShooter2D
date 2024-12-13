using Entitas;
using Infrastructure.View;

namespace Common
{
  [Game] public class Destructed : IComponent { }
  [Game] public class View : IComponent { public IEntityView Value; }
  [Game] public class SelfDestructTimer : IComponent { public float Value; }
  [Game] public class DestructTime : IComponent { public float Value; }
}