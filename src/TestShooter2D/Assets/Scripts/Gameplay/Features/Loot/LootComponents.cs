using Entitas;
using UnityEngine;

namespace Gameplay.Features.Loot
{
    [Game] public class Loot : IComponent { }
    [Game] public class LootValue : IComponent { public float Value; }
    [Game] public class CollectorId : IComponent { public int Value; }

    [Game] public class Collectable : IComponent { }
    [Game] public class Collecting : IComponent { }
    [Game] public class Collected : IComponent { }
    [Game] public class Collector : IComponent { }
    [Game] public class CollectSpeed : IComponent { public float Value; }
    [Game] public class CollectDistance : IComponent { public float Value; }
    [Game] public class CollectRadius : IComponent { public float Value; }
    [Game] public class DropChance : IComponent { public float Value; }
    [Game] public class DropPoint : IComponent { public Transform Value; }
}