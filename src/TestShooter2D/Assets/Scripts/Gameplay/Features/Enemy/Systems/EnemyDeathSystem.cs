using Entitas;
using Gameplay.Levels;

namespace Gameplay.Features.Enemy.Systems
{
    public class EnemyDeathSystem : IExecuteSystem
    {
        private readonly ILevelDataProvider _levelDataProvider;
        private readonly IGroup<GameEntity> _enemies;

        public EnemyDeathSystem(GameContext game, ILevelDataProvider levelDataProvider)
        {
            _levelDataProvider = levelDataProvider;
            
            _enemies = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Enemy,
                    GameMatcher.ProcessingDeath,
                    GameMatcher.Dead));
        }

        public void Execute()
        {
            foreach (var enemy in _enemies)
            {
                enemy.AddSelfDestructTimer(enemy.DestructTime);
                _levelDataProvider.SoundService.PlayZombieDeath();
            }
        }
    }
}