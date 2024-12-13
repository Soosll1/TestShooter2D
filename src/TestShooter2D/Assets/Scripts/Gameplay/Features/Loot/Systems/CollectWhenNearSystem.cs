using System.Collections.Generic;
using Entitas;

namespace Gameplay.Features.Loot.Systems
{
    public class CollectWhenNearSystem : IExecuteSystem
    {
        private readonly GameContext _game;
        private readonly IGroup<GameEntity> _collectables;
        private List<GameEntity> _buffer = new(4);

        public CollectWhenNearSystem(GameContext game)
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
            foreach (var collectable in _collectables.GetEntities(_buffer))
            {
                var collector = _game.GetEntityWithId(collectable.CollectorId);
                
                if(collector == null)
                    continue;

                if ((collector.WorldPosition - collectable.WorldPosition).magnitude <= collector.CollectDistance)
                    collectable.isCollected = true;
            }
        }
    }
}