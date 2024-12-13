using Entitas;
using Entitas.CodeGeneration.Attributes;
using Infrastructure.View;
using UnityEngine;

namespace Gameplay.Common
{
   [Game] public class Id : IComponent {[PrimaryEntityIndex] public int Value; }
   [Game] public class Health : IComponent { public float Value; }
   [Game] public class HealthCurrent : IComponent { public float Value; }
   [Game] public class WorldPosition : IComponent { public Vector3 Value; }
   [Game] public class SpriteRendererComponent : IComponent { public SpriteRenderer Value; }
   [Game] public class TurnAlongDirection : IComponent { }
   
   
   [Game] public class ViewPath : IComponent { public string Value; }
   [Game] public class ViewPrefab : IComponent { public EntityBehaviour Value; }
}