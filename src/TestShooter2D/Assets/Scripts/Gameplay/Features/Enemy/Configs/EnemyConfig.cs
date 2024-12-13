using Infrastructure.View;
using UnityEngine;

namespace Gameplay.Features.Enemy.Configs
{
    [CreateAssetMenu(menuName = "Static Data/Enemy", fileName = "EnemyConfig", order = 51)]
    public class EnemyConfig : ScriptableObject
    {
        public EnemyTypeId ZombieTypeId;
        
        public float Health;
        public float Speed;
        public float Damage;
        public float CastRange;
        public float DropChance;
        public float DestructTime;
        
        public EntityBehaviour ViewPrefab;
    }
}