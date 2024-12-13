using Entitas;
using Gameplay.Common.Time;
using UnityEngine;

namespace Gameplay.Features.Movement.Systems
{
    public class DirectionalMovementSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _movers;

        public DirectionalMovementSystem(GameContext game, ITimeService time)
        {
            _time = time;
            
            _movers = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.MovementAvailable,
                    GameMatcher.Speed,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (var mover in _movers)
            {
                mover.ReplaceWorldPosition(mover.WorldPosition + mover.Direction.normalized * mover.Speed * _time.DeltaTime);
            }
        }
    }
}