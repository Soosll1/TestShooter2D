using Entitas;
using Gameplay.Features.Enemy.Behaviours;

namespace Gameplay.Features.Enemy
{
    [Game] public class Enemy : IComponent { }
    [Game] public class EnemySpawner : IComponent { }
    [Game] public class SpawnReady : IComponent { }
    [Game] public class SpawnTime : IComponent { public float Value; }
    [Game] public class HealthBarComponent : IComponent { public HealthBar Value; }
    [Game] public class TimeLeft : IComponent { public float Value; }

}