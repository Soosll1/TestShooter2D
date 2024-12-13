using Infrastructure.View;
using UnityEngine;

namespace Gameplay.Features.Armament.Configs
{
    [CreateAssetMenu(menuName = "Static Data/Armament", fileName = "ArmamentConfig", order = 51)]
    public class ArmamentConfig : ScriptableObject
    {
        public ProjectileSetup ProjectileSetup;

        public EntityBehaviour ViewPrefab;
    }
}