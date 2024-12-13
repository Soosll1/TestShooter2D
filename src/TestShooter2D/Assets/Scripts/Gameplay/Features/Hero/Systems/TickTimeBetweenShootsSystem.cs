using Entitas;
using Gameplay.Common.Time;

namespace Gameplay.Features.Hero.Systems
{
    public class TickTimeBetweenShootsSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _heroes;

        public TickTimeBetweenShootsSystem(GameContext game, ITimeService time)
        {
            _time = time;
            
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.TimeBetweenShoots,
                    GameMatcher.ShootTimeLeft));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            {
                hero.ReplaceShootTimeLeft(hero.ShootTimeLeft - _time.DeltaTime);

                if (hero.ShootTimeLeft <= 0)
                    hero.isCanShoot = true;
            }
        }
    }
}