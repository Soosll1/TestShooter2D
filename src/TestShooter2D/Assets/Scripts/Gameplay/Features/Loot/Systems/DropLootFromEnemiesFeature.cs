using Entitas;
using Gameplay.Features.Loot.Factory;
using UnityEngine;

namespace Gameplay.Features.Loot.Systems
{
    public class DropLootFromEnemiesFeature : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _enemies;
        
        private readonly ILootFactory _lootFactory;

        public DropLootFromEnemiesFeature(GameContext game, ILootFactory lootFactory)
        {
            _lootFactory = lootFactory;
            
            _enemies = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.ProcessingDeath,
                    GameMatcher.Enemy));
        }

        public void Execute()
        {
            foreach (var enemy in _enemies)
            {
                var randomValue = Random.value * 100f;

                if (randomValue <= enemy.DropChance)
                    _lootFactory.CreateLoot(enemy.DropPoint.position);
            }
        }
    }
}