using Entitas;
using Gameplay.Levels;

namespace Gameplay.Features.Hero.Systems
{
    public class HeroDeathSystem : IExecuteSystem
    {
        private readonly ILevelDataProvider _levelDataProvider;
        private readonly IGroup<GameEntity> _heroes;

        public HeroDeathSystem(GameContext game, ILevelDataProvider levelDataProvider)
        {
            _levelDataProvider = levelDataProvider;
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.ProcessingDeath,
                    GameMatcher.Dead));
        }

        public void Execute()
        {
            foreach (var hero in _heroes)
            {
                hero.isShooting = false;
                hero.isMovementAvailable = false;
                hero.AddSelfDestructTimer(hero.DestructTime);
                hero.isMoving = false;
                hero.HeroAnimator.enabled = false;
                
                _levelDataProvider.SoundService.PlayHeroDeath();
            }
        }
    }
}