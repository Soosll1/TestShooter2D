using System.Collections.Generic;
using Entitas;
using Gameplay.Levels;

namespace Gameplay.Features.Enemy.Systems
{
    public class ReactZombieSpawnSystem : ReactiveSystem<GameEntity>
    {
        private readonly ILevelDataProvider _levelDataProvider;

        public ReactZombieSpawnSystem(GameContext game, ILevelDataProvider levelDataProvider) : base(game)
        {
            _levelDataProvider = levelDataProvider;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Enemy);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.isEnemy;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                _levelDataProvider.SoundService.PlayZombieSpawn();
            }
        }
    }
}