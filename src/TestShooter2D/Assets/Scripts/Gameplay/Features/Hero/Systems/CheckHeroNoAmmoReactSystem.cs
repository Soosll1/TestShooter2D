using System.Collections.Generic;
using Entitas;
using Infrastructure.States;
using Infrastructure.States.GameStates;

namespace Gameplay.Features.Hero.Systems
{
    public class CheckHeroNoAmmoReactSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGameStateMachine _stateMachine;

        public CheckHeroNoAmmoReactSystem(GameContext game, IGameStateMachine stateMachine) : base(game)
        {
            _stateMachine = stateMachine;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.AllOf(GameMatcher.Hero, GameMatcher.NoAmmo).Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.isHero && entity.isNoAmmo;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            _stateMachine.Enter<GameOverState>();
        }
    }
}