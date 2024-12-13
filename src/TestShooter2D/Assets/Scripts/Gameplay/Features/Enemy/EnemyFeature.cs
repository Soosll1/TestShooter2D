using Gameplay.Features.Enemy.Systems;
using Infrastructure.Systems;

namespace Gameplay.Features.Enemy
{
    public class EnemyFeature : Feature
    {
        public EnemyFeature(ISystemsFactory systems)
        {
            Add(systems.Create<EnemySpawnTimerSystem>());
            Add(systems.Create<SpawnEnemiesSystem>());
            Add(systems.Create<ReactZombieSpawnSystem>());
            Add(systems.Create<EnemyDeathSystem>());
            
            Add(systems.Create<FinalizeEnemyDeathSystem>());
        }
    }
}