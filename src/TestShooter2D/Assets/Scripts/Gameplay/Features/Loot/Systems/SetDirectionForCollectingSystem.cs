using Entitas;

namespace Gameplay.Features.Loot.Systems
{
    public class SetDirectionForCollectingSystem : IExecuteSystem
    {
        private readonly GameContext _game;
        private readonly IGroup<GameEntity> _collectables;

        public SetDirectionForCollectingSystem(GameContext game)
        {
            _game = game;

            _collectables = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Collecting,
                    GameMatcher.WorldPosition)
                .NoneOf(
                    GameMatcher.Collected));
        }

        public void Execute()
        {
            foreach (var collectable in _collectables)
            {
                var collector = _game.GetEntityWithId(collectable.CollectorId);
                
                if(collector == null)
                    continue;

                collectable.ReplaceDirection((collector.WorldPosition - collectable.WorldPosition).normalized);
            }
        }
    }
}