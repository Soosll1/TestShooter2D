using Entitas;

namespace Gameplay.Features.Hero.Systems
{
    public class CheckHeroAmmoSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;

        public CheckHeroAmmoSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.AmmoCurrent,
                    GameMatcher.AmmoCount));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            {
                if (hero.AmmoCurrent <= 0)
                    hero.isNoAmmo = true;

                else
                    hero.isNoAmmo = false;
            }
        }
    }
}