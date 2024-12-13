using Entitas;

namespace Gameplay.Features.TargetCollection.System
{
    public class CleanupTargetsBufferSystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _casters;

        public CleanupTargetsBufferSystem(GameContext game)
        {
            _casters = game.GetGroup(GameMatcher.TargetsBuffer);
        }

        public void Cleanup()
        {
            foreach (var caster in _casters)
                caster.TargetsBuffer.Clear();
        }
    }
}