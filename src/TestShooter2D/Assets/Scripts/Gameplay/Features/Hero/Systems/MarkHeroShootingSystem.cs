using Entitas;

namespace Gameplay.Features.Hero.Systems
{
    public class MarkHeroShootingSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _inputs;
        private readonly IGroup<GameEntity> _heroes;

        public MarkHeroShootingSystem(GameContext game)
        {
            _inputs = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Input));

            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.CanShoot,
                    GameMatcher.AmmoCount,
                    GameMatcher.AmmoCurrent));
        }

        public void Execute()
        {
            foreach (var input in _inputs)
            foreach (var hero in _heroes)
            {
                if (input.isLeftButtonInput)
                    hero.isShooting = true;
               
                else
                    hero.isShooting = false;
            }
        }
    }
}