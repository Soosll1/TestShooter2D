using Entitas;

namespace Gameplay.Features.Loot.Systems
{
    public class ClearCollectedSystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _collected;

        public ClearCollectedSystem(GameContext game)
        {
            _collected = game.GetGroup(GameMatcher.Collected);
        }

        public void Cleanup()
        {
            foreach (var collected in _collected)
                collected.isDestructed = true;
        }
    }
}