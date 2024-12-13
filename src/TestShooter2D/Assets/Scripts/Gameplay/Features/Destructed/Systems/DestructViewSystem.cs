using Entitas;
using UnityEngine;
using Zenject;

namespace Gameplay.Features.Destructed.Systems
{
    public class DestructViewSystem : ICleanupSystem
    {
        private readonly IInstantiator _instantiator;
        private readonly IGroup<GameEntity> _destructed;

        public DestructViewSystem(GameContext game)
        {
            _destructed = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Destructed,
                    GameMatcher.View));
        }

        public void Cleanup()
        {
            foreach (var entity in _destructed)
            {
                entity.View.ReleaseEntity();
                Object.Destroy(entity.View.GameObject);
            }
        }
    }
}