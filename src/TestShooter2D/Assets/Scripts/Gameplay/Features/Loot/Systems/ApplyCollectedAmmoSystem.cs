using Entitas;
using Gameplay.Levels;
using UnityEngine;

namespace Gameplay.Features.Loot.Systems
{
    public class ApplyCollectedAmmoSystem : IExecuteSystem
    {
        private readonly GameContext _game;
        private readonly ILevelDataProvider _levelDataProvider;
        private readonly IGroup<GameEntity> _collected;

        public ApplyCollectedAmmoSystem(GameContext game, ILevelDataProvider levelDataProvider)
        {
            _game = game;
            _levelDataProvider = levelDataProvider;

            _collected = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Collected,
                    GameMatcher.Loot));
        }

        public void Execute()
        {
            foreach (var collected in _collected)
            {
                var collector = _game.GetEntityWithId(collected.CollectorId);
                
                if(collector == null)
                    continue;

                collector.ReplaceAmmoCurrent(collector.AmmoCurrent + (int)collected.LootValue);
                
                _levelDataProvider.SoundService.PlayHeroCollect();
            }
        }
    }
}