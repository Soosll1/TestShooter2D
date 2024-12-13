using Entitas;

namespace Gameplay.Features.DamageApplication.Systems
{
    public class DamageSystem : IExecuteSystem
    {
        private readonly GameContext _game;
        private readonly IGroup<GameEntity> _damageDealers;

        public DamageSystem(GameContext game)
        {
            _game = game;
            
            _damageDealers = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.TargetsBuffer,
                    GameMatcher.Damage));
        }

        public void Execute()
        {
            foreach (var damageDealer in _damageDealers)
            foreach (var targetId in damageDealer.TargetsBuffer)
            {
                var target = _game.GetEntityWithId(targetId);
                
                if(target == null)
                    continue;
                
                if(target.hasHealthCurrent == false)
                    continue;

                target.ReplaceHealthCurrent(target.HealthCurrent - damageDealer.Damage);

                if (target.hasHealthBar)
                {
                    target.HealthBar.Set(target.HealthCurrent, target.Health);
                }
            }
        }
    }
}