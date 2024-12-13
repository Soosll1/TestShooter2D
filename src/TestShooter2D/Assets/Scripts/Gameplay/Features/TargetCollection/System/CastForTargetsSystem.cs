using System.Linq;
using Entitas;
using Gameplay.Common.Physics;
using UnityEngine;

namespace Gameplay.Features.TargetCollection.System
{
    public class CastForTargetsSystem : IExecuteSystem
    {
        private readonly IPhysicsService _physicsService;
        private readonly IGroup<GameEntity> _casters;

        public CastForTargetsSystem(GameContext game, IPhysicsService physicsService)
        {
            _physicsService = physicsService;
            
            _casters = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.TargetsBuffer,
                    GameMatcher.LayerMask,
                    GameMatcher.CastRange));
        }

        public void Execute()
        {
            foreach (var caster in _casters)
            {
                var targets = _physicsService
                    .CircleCast(
                        caster.WorldPosition,
                        caster.CastRange, 
                        caster.LayerMask);
                
                caster.TargetsBuffer.AddRange(targets.Select(x => x.Id));
            }
        }
    }
}