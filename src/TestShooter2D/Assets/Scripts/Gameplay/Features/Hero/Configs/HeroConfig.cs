using Infrastructure.View;
using UnityEngine;

namespace Gameplay.Features.Hero.Configs
{
    [CreateAssetMenu(menuName = "Static Data/Hero", fileName = "HeroConfig", order = 51)]
    public class HeroConfig : ScriptableObject
    {
        public float Health;
        public float Speed;
        public float TimeBetweenShoots;
        public float CollectSpeed;
        public float CollectDistance;
        public float CollectRadius;
        public float DestructTime;

        public int AmmoCount;

        public EntityBehaviour ViewPrefab;
    }
}