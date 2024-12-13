using System.Collections.Generic;
using Entitas;

namespace Gameplay.Features.Enemy.Systems
{
    public class FinalizeEnemyDeathSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _enemies;
        private List<GameEntity> _buffer = new(16);

        public FinalizeEnemyDeathSystem(GameContext game)
        {
            _enemies = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Enemy,
                    GameMatcher.ProcessingDeath,
                    GameMatcher.Dead));
        }

        public void Execute()
        {
            foreach (var enemy in _enemies.GetEntities(_buffer))
            {
                enemy.isProcessingDeath = false;
            }
        }
    }
}