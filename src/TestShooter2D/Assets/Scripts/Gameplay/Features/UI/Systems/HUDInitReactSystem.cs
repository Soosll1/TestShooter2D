using System.Collections.Generic;
using Entitas;

namespace Gameplay.Features.UI.Systems
{
    public class HUDInitReactSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _heroes;
        private readonly IGroup<GameEntity> _HUDs;
        
        public HUDInitReactSystem(GameContext game) : base(game)
        {
            _heroes = game.GetGroup(GameMatcher.Hero);
            _HUDs = game.GetGroup(GameMatcher.HUD);
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Hero.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.isHero = true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var huD in _HUDs)
            foreach (var hero in _heroes)
            {
                huD.AddAmmoCount(hero.AmmoCount);
            }
        }
    }
}