using System.Collections.Generic;
using Entitas;

namespace Gameplay.Features.Destructed.Systems
{
    public class DestructEntitySystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _destructed;
        private List<GameEntity> _buffer = new(16);

        public DestructEntitySystem(GameContext game)
        {
            _destructed = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Destructed));
        }

        public void Cleanup()
        {
            foreach (var entity in _destructed.GetEntities(_buffer))
                entity.Destroy();
        }
    }
}