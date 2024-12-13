using Entitas;

namespace Gameplay.Features.Hero.Systems
{
    public class StopHeroWhileShootingSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;

        public StopHeroWhileShootingSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.CanShoot,
                    GameMatcher.AmmoCount,
                    GameMatcher.AmmoCurrent));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            {
                if (hero.isShooting)
                    hero.isMovementAvailable = false;

                else
                    hero.isMovementAvailable = true;
            }
        }
    }
}