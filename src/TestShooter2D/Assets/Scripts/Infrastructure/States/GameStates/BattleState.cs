using Common.Entity;
using Common.Extensions;
using Gameplay.Features.Hero.Factory;
using Gameplay.Levels;
using Infrastructure.States.GameStates.Common;
using UnityEngine;

namespace Infrastructure.States.GameStates
{
    public class BattleState : IState
    {
        private readonly IHeroFactory _heroFactory;
        private readonly ILevelDataProvider _levelDataProvider;

        public BattleState(IHeroFactory heroFactory, ILevelDataProvider levelDataProvider)
        {
            _heroFactory = heroFactory;
            _levelDataProvider = levelDataProvider;
        }
        
        public void Enter()
        {
            CreateHero();
            CreateSpawner();
        }

        private void CreateHero()
        {
            _heroFactory.CreateHero(_levelDataProvider.StartPoint);
        }

        private static void CreateSpawner()
        {
            var spawnTime = Random.Range(GameConstants.MinSpawnTime, GameConstants.MaxSpawnTime);

            CreateEntity.Empty()
                .AddTimeLeft(spawnTime)
                .With(x => x.isEnemySpawner = true)
                .With(x => x.isSpawnReady = true);
        }

        public void Exit()
        {
        }
    }
}