using System.Collections.Generic;
using Common.Extensions;
using Entitas;
using Gameplay.Features.Enemy.Factory;
using Gameplay.Levels;
using Infrastructure.Installers;
using UnityEngine;

namespace Gameplay.Features.Enemy.Systems
{
    public class SpawnEnemiesSystem : IExecuteSystem
    {
        private readonly ILevelDataProvider _levelDataProvider;

        private readonly IEnemyFactory _enemyFactory;
        private readonly IGroup<GameEntity> _spawners;
        private readonly IGroup<GameEntity> _heroes;

        private List<GameEntity> _buffer = new(4);

        public SpawnEnemiesSystem(GameContext game, IEnemyFactory enemyFactory, ILevelDataProvider levelDataProvider)
        {
            _enemyFactory = enemyFactory;
            _levelDataProvider = levelDataProvider;

            _heroes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Hero,
                    GameMatcher.WorldPosition));
            
            _spawners = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.EnemySpawner,
                    GameMatcher.SpawnReady));
        }

        public void Execute()
        {
            foreach (var spawner in _spawners.GetEntities(_buffer))
            foreach (var hero in _heroes)
            {
                var randomSpawnPoint = _levelDataProvider.SpawnPoints.PickRandom();

                var direction = new Vector3(hero.WorldPosition.x - randomSpawnPoint.position.x, 0f, 0f);

                _enemyFactory.CreateRandomZombie(randomSpawnPoint.position)
                    .AddDirection(direction)
                    .With(x => x.isMoving = true);

                spawner.isSpawnReady = false;
            }
        }
    }
}