using System.Linq;
using Entitas;

namespace Gameplay.Features.Armament.Systems
{
    public class MarkDestructedArmamentAfterHitSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _armaments;

        public MarkDestructedArmamentAfterHitSystem(GameContext game)
        {
            _armaments = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Armament,
                    GameMatcher.TargetsBuffer));
        }

        public void Execute()
        {
            foreach (var armament in _armaments)
            {
                if (armament.TargetsBuffer.Any())
                    armament.isDestructed = true;
            }
        }
    }
}