using System.Collections.Generic;
using Entitas;

namespace Gameplay.Features.Death.Systems
{
    public class MarkDeadSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private List<GameEntity> _buffer = new(16);

        public MarkDeadSystem(GameContext game)
        {
            _entities = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Health,
                    GameMatcher.HealthCurrent,
                    GameMatcher.WorldPosition)
                .NoneOf(
                    GameMatcher.Dead));
        }

        public void Execute()
        {
            foreach (var entity in _entities.GetEntities(_buffer))
            {
                if (entity.HealthCurrent <= 0)
                {
                    entity.isDead = true;
                    entity.isProcessingDeath = true;
                }
            }
        }
    }
}