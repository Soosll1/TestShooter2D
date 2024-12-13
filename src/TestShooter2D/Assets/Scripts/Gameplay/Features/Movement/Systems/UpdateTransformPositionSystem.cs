using Entitas;

namespace Gameplay.Features.Movement.Systems
{
    public class UpdateTransformPositionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;

        public UpdateTransformPositionSystem(GameContext game)
        {
            _entities = game.GetGroup(
                GameMatcher.AllOf(
                    GameMatcher.WorldPosition,
                    GameMatcher.View));
        }

        public void Execute()
        {
            foreach (var entity in _entities)
                entity.View.GameObject.transform.position = entity.WorldPosition;
        }
    }
}