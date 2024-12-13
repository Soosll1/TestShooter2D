using Common.Extensions;
using Entitas;
using Infrastructure;
using UnityEngine;

namespace Gameplay.Features.Movement.Systems
{
    public class TurnAlongDirectionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movers;

        public TurnAlongDirectionSystem(GameContext game)
        {
            _movers = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.WorldPosition,
                    GameMatcher.TurnAlongDirection,
                    GameMatcher.SpriteRenderer,
                    GameMatcher.Moving,
                    GameMatcher.View));
        }
        
        public void Execute()
        {
            foreach (var mover in _movers)
            {
                var scale = Mathf.Abs(mover.SpriteRenderer.transform.localScale.x); 
                
                mover.SpriteRenderer.transform.SetScaleX(scale * FaceDirection(mover));
            }
        }

        private float FaceDirection(GameEntity entity)
        {
            return entity.Direction.x >= 0 ? GameConstants.DefaultLocalScaleX : -GameConstants.DefaultLocalScaleX;
        }
    }
}