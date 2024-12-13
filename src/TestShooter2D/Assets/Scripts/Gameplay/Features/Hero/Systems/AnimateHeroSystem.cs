using Entitas;

namespace Gameplay.Features.Hero.Systems
{
    public class AnimateHeroSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;

        public AnimateHeroSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.HeroAnimator));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            {
                if (hero.isShooting)
                {
                    hero.HeroAnimator.PlayShoot(true);
                }

                else
                {
                    hero.HeroAnimator.PlayShoot(false);
                }
                
                if (hero.isMoving)
                {
                    hero.HeroAnimator.PlayMove(true);
                }

                else
                {
                    hero.HeroAnimator.PlayMove(false);
                }
            }
        }
    }
}