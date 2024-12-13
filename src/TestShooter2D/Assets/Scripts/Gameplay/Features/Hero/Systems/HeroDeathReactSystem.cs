using System.Collections.Generic;
using Entitas;
using Infrastructure.States;
using Infrastructure.States.GameStates;
using UnityEngine;

namespace Gameplay.Features.Hero.Systems
{
    public class HeroDeathReactSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGameStateMachine _stateMachine;

        public HeroDeathReactSystem(GameContext game, IGameStateMachine stateMachine) : base(game)
        {
            _stateMachine = stateMachine;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.AllOf(GameMatcher.Hero, GameMatcher.ProcessingDeath));
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.isHero;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                _stateMachine.Enter<GameOverState>();
            }
        }
    }
}