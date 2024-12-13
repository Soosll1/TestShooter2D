using Common.Extensions;
using Entitas;
using Gameplay.Common.Time;

namespace Gameplay.Features.Loot.Systems
{
    public class CollectingSystem : IExecuteSystem
    {
        private readonly GameContext _game;
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _collectables;

        public CollectingSystem(GameContext game, ITimeService time)
        {
            _game = game;
            _time = time;

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

                collectable.ReplaceWorldPosition(
                    collectable.WorldPosition +
                    collectable.Direction * 
                    collector.CollectSpeed * 
                    _time.DeltaTime);
            }
        }
    }
}