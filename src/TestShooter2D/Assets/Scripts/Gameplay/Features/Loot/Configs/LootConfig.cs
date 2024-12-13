using Infrastructure.View;
using UnityEngine;

namespace Gameplay.Features.Loot.Configs
{
    [CreateAssetMenu(menuName = "Static Data/Loot", fileName = "LootConfig", order = 51)]
    public class LootConfig : ScriptableObject
    {
        public float MinValue;
        public float MaxValue;

        public EntityBehaviour ViewPrefab;
    }
}