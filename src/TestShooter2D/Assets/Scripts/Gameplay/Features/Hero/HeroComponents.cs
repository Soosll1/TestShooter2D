using Entitas;
using UnityEngine;

namespace Gameplay.Features.Hero
{
    [Game] public class Hero : IComponent { }
    [Game] public class Shooting : IComponent { }
    [Game] public class NoAmmo : IComponent { }
    
    [Game] public class HeroAnimatorComponent : IComponent { public HeroAnimator Value; }
    [Game] public class HeroShootPoint : IComponent { public Transform Value; }
    
    [Game] public class TimeBetweenShoots : IComponent { public float Value; }
    [Game] public class ShootTimeLeft : IComponent { public float Value; }
    [Game] public class CanShoot : IComponent { }
    
    [Game] public class AmmoCount : IComponent { public int Value; }
    [Game] public class AmmoCurrent : IComponent { public int Value; }

}