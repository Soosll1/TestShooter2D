using System.Collections.Generic;
using Entitas;

namespace Gameplay.Features.Hero.Systems
{
    public class FinalizeHeroDeathSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;
        private List<GameEntity> _buffer = new(4);

        public FinalizeHeroDeathSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.ProcessingDeath,
                    GameMatcher.Dead));
        }

        public void Execute()
        {
            foreach (var hero in _heroes.GetEntities(_buffer))
                hero.isProcessingDeath = false;
        }
    }
}