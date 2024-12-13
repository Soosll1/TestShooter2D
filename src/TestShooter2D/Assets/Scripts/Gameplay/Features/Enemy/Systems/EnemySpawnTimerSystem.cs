using Entitas;
using Gameplay.Common.Time;
using Infrastructure;
using UnityEngine;

namespace Gameplay.Features.Enemy.Systems
{
    public class EnemySpawnTimerSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _spawners;

        public EnemySpawnTimerSystem(GameContext game, ITimeService time)
        {
            _time = time;
            
            _spawners = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.EnemySpawner,
                    GameMatcher.TimeLeft));
        }

        public void Execute()
        {
            foreach (var spawner in _spawners)
            {
                spawner.ReplaceTimeLeft(spawner.TimeLeft - _time.DeltaTime);

                if (spawner.TimeLeft <= 0)
                {
                    var spawnTime = Random.Range(GameConstants.MinSpawnTime, GameConstants.MaxSpawnTime);
                    spawner.isSpawnReady = true;
                    spawner.ReplaceTimeLeft(spawnTime);
                }
            }
        }
    }
}