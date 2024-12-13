using System.Collections.Generic;
using Entitas;
using Gameplay.Common.Time;

namespace Gameplay.Features.Destructed.Systems
{
    public class SelfDestructSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _entities;
        private List<GameEntity> _buffer = new(16);

        public SelfDestructSystem(GameContext game, ITimeService time)
        {
            _time = time;
            
            _entities = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.SelfDestructTimer));
        }

        public void Execute()
        {
            foreach (var entity in _entities.GetEntities(_buffer))
            {
                entity.ReplaceSelfDestructTimer(entity.SelfDestructTimer - _time.DeltaTime);

                if (entity.SelfDestructTimer <= 0)
                {
                    entity.RemoveSelfDestructTimer();
                    entity.isDestructed = true;
                }
            }
        }
    }
}