using Common.Extensions;
using Entitas;
using Gameplay.Common.Physics;

namespace Gameplay.Features.Loot.Systems
{
    public class CastForCollectableSystem : IExecuteSystem
    {
        private readonly IPhysicsService _physicsService;
        private readonly IGroup<GameEntity> _collectors;
        private readonly GameEntity[] _collected = new GameEntity[32];
        private readonly int _collectableLayer = CollisionLayer.Collectable.AsMask();

        public CastForCollectableSystem(GameContext game, IPhysicsService physicsService)
        {
            _physicsService = physicsService;
            _collectors = game.GetGroup(GameMatcher
                    .AllOf(
                        GameMatcher.Collector,
                        GameMatcher.CollectRadius,
                        GameMatcher.CollectSpeed,
                        GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (var collector in _collectors)
            {
                var collected = _physicsService
                    .CircleCastNonAlloc(
                        collector.WorldPosition,
                        collector.CollectRadius,
                        _collectableLayer, _collected);
                
                for (int i = 0; i < collected; i++)
                {
                    var entity = _collected[i];
                    
                    if(entity.isCollecting)
                        continue;

                    entity.isCollecting = true;
                    entity.isCollectable = false;
                    entity.AddCollectorId(collector.Id);
                    
                    entity
                        .ReplaceSpeed(collector.CollectSpeed)
                        .With(x => x.isMoving = true);
                }
            }
            
            ClearBuffer();
        }

        private void ClearBuffer()
        {
            for (var i = 0; i < _collected.Length; i++)
                _collected[i] = null;
        }
    }
}